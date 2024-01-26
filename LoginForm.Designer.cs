namespace LoginForm
{
    partial class LoginForm
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
            LoginTextbox = new TextBox();
            AuthoriseButton = new Button();
            PasswordTextbox = new TextBox();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            RegisterLabel = new LinkLabel();
            ErrorLabel = new Label();
            SuspendLayout();
            // 
            // LoginTextbox
            // 
            LoginTextbox.Location = new Point(122, 96);
            LoginTextbox.Name = "LoginTextbox";
            LoginTextbox.Size = new Size(100, 23);
            LoginTextbox.TabIndex = 0;
            LoginTextbox.TextChanged += LoginTextBox_TextChanged;
            // 
            // AuthoriseButton
            // 
            AuthoriseButton.Location = new Point(132, 221);
            AuthoriseButton.Name = "AuthoriseButton";
            AuthoriseButton.Size = new Size(75, 23);
            AuthoriseButton.TabIndex = 2;
            AuthoriseButton.Text = "Authorise";
            AuthoriseButton.UseVisualStyleBackColor = true;
            AuthoriseButton.Click += AuthoriseButton_Click;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Location = new Point(122, 165);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(100, 23);
            PasswordTextbox.TabIndex = 3;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(123, 78);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(37, 15);
            LoginLabel.TabIndex = 4;
            LoginLabel.Text = "Login";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(122, 147);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "Password";
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.Location = new Point(120, 247);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(102, 15);
            RegisterLabel.TabIndex = 6;
            RegisterLabel.TabStop = true;
            RegisterLabel.Text = "Have no account?";
            RegisterLabel.LinkClicked += RegisterLabel_LinkClicked;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(87, 272);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 15);
            ErrorLabel.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 324);
            Controls.Add(ErrorLabel);
            Controls.Add(RegisterLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(PasswordTextbox);
            Controls.Add(AuthoriseButton);
            Controls.Add(LoginTextbox);
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextbox;
        private Button AuthoriseButton;
        private TextBox PasswordTextbox;
        private Label LoginLabel;
        private Label PasswordLabel;
        private LinkLabel RegisterLabel;
        private Label ErrorLabel;
    }
}
