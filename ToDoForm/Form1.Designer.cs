namespace ToDoForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            labelMessage = new Label();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(490, 204);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(122, 27);
            textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(490, 263);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(122, 27);
            textBoxPassword.TabIndex = 1;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(522, 354);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(67, 20);
            labelMessage.TabIndex = 2;
            labelMessage.Text = "Message";
            labelMessage.Click += label1_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(507, 296);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(105, 29);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogin);
            Controls.Add(labelMessage);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label labelMessage;
        private Button buttonLogin;
    }
}
