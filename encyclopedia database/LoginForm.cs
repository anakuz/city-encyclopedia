using System;
using System.Windows.Forms;

namespace encyclopedia_database
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            passwordTB.UseSystemPasswordChar = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Helper.ExtractLogin(usernameTB.Text);
            Helper.Login(Helper.GetConnString(usernameTB.Text, passwordTB.Text));
        }
    }
}
