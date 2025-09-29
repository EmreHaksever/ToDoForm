using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoForm
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            this.Load += DashboardForm_Load;
            
            comboBoxUser.SelectedIndexChanged += comboBoxUser_SelectedIndexChanged;
        }

        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            await LoadUsers();
            await RefreshTasks();
        }

        // Kullanıcıları API'den çek
        private async Task LoadUsers()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Session.Token);

                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://localhost:7136/api/user");
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonData = await response.Content.ReadAsStringAsync();
                        var users = JsonSerializer.Deserialize<List<UserItem>>(jsonData);

                        if (users != null && users.Count > 0)
                        {
                            comboBoxUser.DataSource = users;
                            comboBoxUser.DisplayMember = "Username";
                            comboBoxUser.ValueMember = "Id";
                            comboBoxUser.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Hiç kullanıcı bulunamadı.");
                        }
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Kullanıcılar alınamadı: " + response.StatusCode + "\n" + error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        // Task listesini çek
        private async Task RefreshTasks()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Session.Token);
                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://localhost:7136/api/task");
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonData = await response.Content.ReadAsStringAsync();

                        // JsonSerializerOptions ekleyin
                        var options = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true,
                            NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString
                        };

                        var tasks = JsonSerializer.Deserialize<List<TaskItem>>(jsonData, options);
                        dataGridViewTasks.DataSource = tasks;
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Görevler alınamadı: " + response.StatusCode + "\n" + error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message + "\n\nDetay: " + ex.InnerException?.Message);
                }
            }
        }

        // Yeni task ekle
        private async void buttonAddTask_Click(object sender, EventArgs e)
        {
            // Title ve Description boş mu kontrol et
            if (string.IsNullOrWhiteSpace(textBoxTaskTitle.Text))
            {
                MessageBox.Show("Task başlığını giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTaskTitle.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxTaskDescription.Text))
            {
                MessageBox.Show("Task açıklamasını giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTaskDescription.Focus();
                return;
            }

            if (comboBoxUser.SelectedItem is UserItem selectedUser)
            {
                var newTask = new
                {
                    title = textBoxTaskTitle.Text,
                    description = textBoxTaskDescription.Text,
                    dueDate = dateTimePickerDueDate.Value,
                    status = 0,  // 0 = Todo
                    userId = selectedUser.Id
                };

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Session.Token);

                    string json = JsonSerializer.Serialize(newTask);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync("https://localhost:7136/api/task", content);
                    string result = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("✅ Task eklendi!");
                        await RefreshTasks();

                        // Formu temizle
                        textBoxTaskTitle.Clear();
                        textBoxTaskDescription.Clear();
                        dateTimePickerDueDate.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("❌ Task eklenemedi: " + result);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.");
            }
        }

        private async void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.CurrentRow == null)
            {
                MessageBox.Show("Silmek için bir task seçiniz.");
                return;
            }

            // Seçili task'ın Id'sini al
            if (dataGridViewTasks.CurrentRow.DataBoundItem is TaskItem selectedTask)
            {
                var confirm = MessageBox.Show(
                    $"'{selectedTask.Title}' taskını silmek istediğinize emin misiniz?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Authorization =
                            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Session.Token);

                        HttpResponseMessage response = await client.DeleteAsync($"https://localhost:7136/api/task/{selectedTask.Id}");
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("✅ Task silindi!");
                            await RefreshTasks();
                        }
                        else
                        {
                            string result = await response.Content.ReadAsStringAsync();
                            MessageBox.Show("❌ Task silinemedi: " + result);
                        }
                    }
                }
            }
        }



        // ComboBox seçimi değiştiğinde (debug için)
        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUser.SelectedItem is UserItem user)
            {
                Console.WriteLine($"Seçilen kullanıcı: {user.Name} ({user.Id})");
            }
        }
    }
}
