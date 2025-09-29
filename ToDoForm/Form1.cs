using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoForm
{
    public partial class Form1 : Form
    {
        private static string _token; // Token burada saklanacak
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            using (HttpClient client = new HttpClient())
            {
                var loginData = new { Username = username, PasswordHash = password };
                string json = JsonSerializer.Serialize(loginData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync("https://localhost:7136/api/auth/login", content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var result = JsonSerializer.Deserialize<LoginResponse>(responseBody);

                        if (result != null && !string.IsNullOrEmpty(result.token))
                        {
                            Session.Token = result.token;  // Token burada saklanıyor
                            labelMessage.Text = "✅ Giriş başarılı!";

                            // Yeni formu aç
                            var dashboard = new DashboardForm();
                            dashboard.Show();

                            // Login formunu gizle
                            this.Hide();
                        }
                        else
                        {
                            labelMessage.Text = "❌ Kullanıcı adı veya şifre hatalı!";
                        }
                    }
                    else
                    {
                        labelMessage.Text = "⚠️ API'ye bağlanılamadı! Status: " + response.StatusCode;
                    }
                }
                catch (Exception ex)
                {
                    labelMessage.Text = "Hata: " + ex.Message;
                }
            }
        }

        private async void buttonAddUser_Click(object sender, EventArgs e)
        {
            string username = textBoxNewUsername.Text;
            string password = textBoxNewPassword.Text;
            string role = comboBoxNewRole.SelectedItem?.ToString() ?? "User";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz!");
                return;
            }

            var newUser = new
            {
                username = username,
                passwordHash = password,
                role = role
            };

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Session.Token);

                string json = JsonSerializer.Serialize(newUser);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync("https://localhost:7136/api/user", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("✅ Kullanıcı başarıyla eklendi!");
                        textBoxNewUsername.Clear();
                        textBoxNewPassword.Clear();
                        comboBoxNewRole.SelectedIndex = 1;
                    }
                    else
                    {
                        MessageBox.Show("❌ Kullanıcı eklenemedi! Status: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }


        public class LoginResponse
        {
            public string token { get; set; }
        }
    }
}


