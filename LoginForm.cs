using System.Text.Json;

namespace LoginForm
{
    public partial class LoginForm : Form
    {

        private List<Account> _accounts = new();
        private string _fileName = "C:\\Users\\landi\\source\\repos\\LoginForm\\LoginForm\\auth.json";

        

      
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            _accounts.GetAccounts(_fileName);
        }

        private void RegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registrationForm = new RegisterForm();
            registrationForm.ShowDialog();
        }

        private void AuthoriseButton_Click(object sender, EventArgs e)
        {

            _accounts.GetAccounts(_fileName);
            
            if(_accounts == null)
            {
                MessageBox.Show("We have no any users!");
                return;
            }
            var authorisedAccount =  _accounts.FirstOrDefault(ac => ac.Login == LoginTextbox.Text && ac.Password == PasswordTextbox.Text);
            if (authorisedAccount != null)
            {
                MessageBox.Show("Succes!");
            }
            else
            {
                ErrorLabel.Text = "Login or password are incorrect!";
            }

        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
