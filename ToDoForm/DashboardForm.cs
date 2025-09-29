using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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

        private bool isAdmin = false;

        private async Task CheckUserRole()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Session.Token);

                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://localhost:7136/api/user/me");
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonData = await response.Content.ReadAsStringAsync();

                        var currentUser = JsonSerializer.Deserialize<UserItem>(jsonData, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

                        if (currentUser != null)
                            isAdmin = currentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Rol bilgisi alınamadı: " + ex.Message);
                }
            }
        }

        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            await CheckUserRole();
            await LoadUsers();
            await RefreshTasks();

            if (!isAdmin)
            {
                textBoxTaskTitle.Visible = false;
                textBoxTaskDescription.Visible = false;
                dateTimePickerDueDate.Visible = false;
                buttonAddTask.Visible = false;
                comboBoxUser.Visible = false;
            }
        }

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
                        var users = JsonSerializer.Deserialize<List<UserItem>>(jsonData, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

                        if (users != null && users.Count > 0)
                        {
                            // Debug: API’den gelen kullanıcıları yazdır
                            foreach (var u in users)
                                Console.WriteLine($"Id: {u.Id}, Username: {u.Username}, Name: {u.Name}, Role: {u.Role}");

                            comboBoxUser.DataSource = users;
                            comboBoxUser.DisplayMember = "Username"; // Görünür alan
                            comboBoxUser.ValueMember = "Id";         // Seçilen değer
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

                        var options = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true,
                            NumberHandling = JsonNumberHandling.AllowReadingFromString
                        };

                        var tasks = JsonSerializer.Deserialize<List<TaskItem>>(jsonData, options);
                        dataGridViewTasks.DataSource = tasks;

                        // Status sütununu gizle
                        if (dataGridViewTasks.Columns["Status"] != null)
                            dataGridViewTasks.Columns["Status"].Visible = false;
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


        private async void buttonAddTask_Click(object sender, EventArgs e)
        {
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
                    status = 0,
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Session.Token = null;
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUser.SelectedItem is UserItem user)
                Console.WriteLine($"Seçilen kullanıcı: {user.Username} ({user.Id})");
        }
    }

    // Kullanıcı sınıfı
    public class UserItem
    {
        public int Id { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("role")]
        public string Role { get; set; } = string.Empty;

        public override string ToString() => Username; // ComboBox görünürlük için
    }
}
