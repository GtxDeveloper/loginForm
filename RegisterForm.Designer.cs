namespace LoginForm
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameTb = new TextBox();
            SurnameTb = new TextBox();
            LoginTb = new TextBox();
            EmailTb = new TextBox();
            PasswordTb = new TextBox();
            PasswordLabel = new Label();
            EmailLabel = new Label();
            LoginLabel = new Label();
            SurnameLabel = new Label();
            NameLabel = new Label();
            PasswordError = new Label();
            LoginError = new Label();
            EmailError = new Label();
            CreateButton = new Button();
            SuspendLayout();
            // 
            // NameTb
            // 
            NameTb.Location = new Point(91, 43);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(138, 23);
            NameTb.TabIndex = 0;
            // 
            // SurnameTb
            // 
            SurnameTb.Location = new Point(91, 111);
            SurnameTb.Name = "SurnameTb";
            SurnameTb.Size = new Size(138, 23);
            SurnameTb.TabIndex = 1;
            // 
            // LoginTb
            // 
            LoginTb.Location = new Point(91, 185);
            LoginTb.Name = "LoginTb";
            LoginTb.Size = new Size(138, 23);
            LoginTb.TabIndex = 2;
            // 
            // EmailTb
            // 
            EmailTb.Location = new Point(91, 262);
            EmailTb.Name = "EmailTb";
            EmailTb.Size = new Size(138, 23);
            EmailTb.TabIndex = 3;
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(91, 334);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(138, 23);
            PasswordTb.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(91, 316);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "Password";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(91, 244);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 6;
            EmailLabel.Text = "Email";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(91, 167);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(37, 15);
            LoginLabel.TabIndex = 7;
            LoginLabel.Text = "Login";
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Location = new Point(91, 93);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(54, 15);
            SurnameLabel.TabIndex = 8;
            SurnameLabel.Text = "Surname";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(91, 24);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 9;
            NameLabel.Text = "Name";
            // 
            // PasswordError
            // 
            PasswordError.AutoSize = true;
            PasswordError.ForeColor = Color.Red;
            PasswordError.Location = new Point(89, 360);
            PasswordError.Name = "PasswordError";
            PasswordError.Size = new Size(0, 15);
            PasswordError.TabIndex = 10;
            // 
            // LoginError
            // 
            LoginError.AutoSize = true;
            LoginError.ForeColor = Color.Red;
            LoginError.Location = new Point(91, 211);
            LoginError.Name = "LoginError";
            LoginError.Size = new Size(0, 15);
            LoginError.TabIndex = 11;
            LoginError.Click += LoginError_Click;
            // 
            // EmailError
            // 
            EmailError.AutoSize = true;
            EmailError.ForeColor = Color.Red;
            EmailError.Location = new Point(89, 288);
            EmailError.Name = "EmailError";
            EmailError.Size = new Size(0, 15);
            EmailError.TabIndex = 12;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(116, 396);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(75, 23);
            CreateButton.TabIndex = 13;
            CreateButton.Text = "Create ";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += button1_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 450);
            Controls.Add(CreateButton);
            Controls.Add(EmailError);
            Controls.Add(LoginError);
            Controls.Add(PasswordError);
            Controls.Add(NameLabel);
            Controls.Add(SurnameLabel);
            Controls.Add(LoginLabel);
            Controls.Add(EmailLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTb);
            Controls.Add(EmailTb);
            Controls.Add(LoginTb);
            Controls.Add(SurnameTb);
            Controls.Add(NameTb);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTb;
        private TextBox SurnameTb;
        private TextBox LoginTb;
        private TextBox EmailTb;
        private TextBox PasswordTb;
        private Label PasswordLabel;
        private Label EmailLabel;
        private Label LoginLabel;
        private Label SurnameLabel;
        private Label NameLabel;
        private Label PasswordError;
        private Label LoginError;
        private Label EmailError;
        private Button CreateButton;
    }
}