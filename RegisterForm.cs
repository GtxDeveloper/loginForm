using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LoginForm
{
    public partial class RegisterForm : Form
    {

        private List<Account> _accounts = new();
        private string _fileName = "C:\\Users\\landi\\source\\repos\\LoginForm\\LoginForm\\auth.json";
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            _accounts.GetAccounts(_fileName);
        }

        private void LoginError_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginPattern = @"^[a-zA-Z0-9_-]{3,20}$";

            
            Regex loginRegex = new Regex(loginPattern);


            if (!loginRegex.IsMatch(LoginTb.Text))
            {
                LoginError.Text = "Incorrect login!";
                return;
            }

            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            
            Regex emailRegex = new Regex(emailPattern);


            if (!emailRegex.IsMatch(EmailTb.Text))
            {
                EmailError.Text = "Incorrect email!";
                return;
            }

            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

           
            Regex passwordRegex = new Regex(passwordPattern);


            if (!passwordRegex.IsMatch(PasswordTb.Text))
            {
                PasswordError.Text = "Incorrect password!";
                return;
            }

            _accounts.Add(new Account
            {
                Name = NameTb.Text,
                Surname = SurnameTb.Text,
                Login = LoginTb.Text,
                Email = EmailTb.Text,
                Password = PasswordTb.Text
            });

            MessageBox.Show("Account created!");

            _accounts.SetAccounts(_fileName);
        }
    }
}
