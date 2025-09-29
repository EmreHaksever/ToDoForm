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
            this.buttonToggleAddUser = new Button();
            this.panelAddUser = new Panel();

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
            this.textBoxUsername.PlaceholderText = "User Name";
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
            this.textBoxPassword.PlaceholderText = "Password";
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
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new EventHandler(this.buttonLogin_Click);

            // 
            // buttonToggleAddUser
            // 
            this.buttonToggleAddUser.Text = "➕ Add User";
            this.buttonToggleAddUser.BackColor = Color.LightGray;
            this.buttonToggleAddUser.ForeColor = Color.Black;
            this.buttonToggleAddUser.Location = new Point(300, 275); // Login butonunun hemen altı
            this.buttonToggleAddUser.Size = new Size(200, 30);
            this.buttonToggleAddUser.Click += (s, e) =>
            {
                panelAddUser.Visible = !panelAddUser.Visible;
            };

            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.ForeColor = Color.Red;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMessage.Location = new Point(300, 320);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new Size(0, 20);
            this.labelMessage.TabIndex = 3;

            // 
            // panelAddUser
            // 
            this.panelAddUser.Size = new Size(250, 220);
            this.panelAddUser.Location = new Point(550, 130); // Login ekranının sağında
            this.panelAddUser.BorderStyle = BorderStyle.FixedSingle;
            this.panelAddUser.Visible = false;

            // Panel içeriği
            Label labelNewUser = new Label();
            labelNewUser.Text = "Add New User";
            labelNewUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNewUser.Location = new Point(10, 10);
            this.panelAddUser.Controls.Add(labelNewUser);

            textBoxNewUsername = new TextBox();
            textBoxNewUsername.PlaceholderText = "User Name";
            textBoxNewUsername.Location = new Point(10, 40);
            textBoxNewUsername.Size = new Size(200, 27);
            this.panelAddUser.Controls.Add(textBoxNewUsername);

            textBoxNewPassword = new TextBox();
            textBoxNewPassword.PlaceholderText = "Password";
            textBoxNewPassword.Location = new Point(10, 80);
            textBoxNewPassword.Size = new Size(200, 27);
            textBoxNewPassword.UseSystemPasswordChar = true;
            this.panelAddUser.Controls.Add(textBoxNewPassword);

            comboBoxNewRole = new ComboBox();
            comboBoxNewRole.Items.AddRange(new string[] { "Admin", "User" });
            comboBoxNewRole.SelectedIndex = 1;
            comboBoxNewRole.Location = new Point(10, 120);
            comboBoxNewRole.Size = new Size(200, 28);
            this.panelAddUser.Controls.Add(comboBoxNewRole);

            buttonAddUser = new Button();
            buttonAddUser.Text = "Add User";
            buttonAddUser.BackColor = Color.CornflowerBlue;
            buttonAddUser.ForeColor = Color.White;
            buttonAddUser.Location = new Point(10, 160);
            buttonAddUser.Size = new Size(200, 35);
            buttonAddUser.Click += buttonAddUser_Click;
            this.panelAddUser.Controls.Add(buttonAddUser);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(850, 450);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonToggleAddUser);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.panelAddUser);
            this.Name = "Form1";
            this.Text = "ToDo Application - Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox textBoxNewUsername;
        private TextBox textBoxNewPassword;
        private ComboBox comboBoxNewRole;
        private Button buttonAddUser;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label labelMessage;
        private Button buttonLogin;
        private Label labelTitle;
        private Panel panelAddUser;
        private Button buttonToggleAddUser;
    }
}
