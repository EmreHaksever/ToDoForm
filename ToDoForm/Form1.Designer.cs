namespace ToDoForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBoxUsername = new TextBox();
            this.textBoxPassword = new TextBox();
            this.labelMessage = new Label();
            this.buttonLogin = new Button();
            this.labelTitle = new Label();
            this.SuspendLayout();

            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = Color.CornflowerBlue;
            this.labelTitle.Location = new Point(310, 50);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(180, 46);
            this.labelTitle.Text = "ToDo Login";
            this.labelTitle.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = Color.WhiteSmoke;
            this.textBoxUsername.ForeColor = Color.Black;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.Location = new Point(300, 130);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PlaceholderText = "Kullanıcı Adı"; // Yeni
            this.textBoxUsername.Size = new Size(200, 30);
            this.textBoxUsername.TabIndex = 0;

            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = Color.WhiteSmoke;
            this.textBoxPassword.ForeColor = Color.Black;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new Point(300, 180);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PlaceholderText = "Şifre"; // Yeni
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.Size = new Size(200, 30);
            this.textBoxPassword.TabIndex = 1;

            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = Color.CornflowerBlue;
            this.buttonLogin.ForeColor = Color.White;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new Point(300, 230);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new Size(200, 35);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Giriş Yap";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new EventHandler(this.buttonLogin_Click);

            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.ForeColor = Color.Red;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMessage.Location = new Point(300, 280);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new Size(0, 20);
            this.labelMessage.TabIndex = 3;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelMessage);
            this.Name = "Form1";
            this.Text = "ToDo Application - Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label labelMessage;
        private Button buttonLogin;
        private Label labelTitle;
    }
}
