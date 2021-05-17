using ManagementFlorarie.BusinessLogic;
using ManagementFlorarie.Models;
using System;
using System.Windows.Forms;

namespace ManagementFlorarie.UI
{
    public partial class LoginForm : Form
    {
        private ContainerBL _containerBL;
        public LoginForm()
        {
            InitializeComponent();
            _containerBL = new ContainerBL();
        }

        public bool IsUserValid(string userName, string password, Utilizator user)
        {
            if (user == null)
            {
                MessageBox.Show("Userul nu exista!\nContacteaza administratorul pentru creare cont!");
                return false;
            }

            if (userName == user.Username && password != user.Parola)
            {
                MessageBox.Show("Parola incorecta!");
                return false;
            }
            return true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username sau parola nu pot fi goale!");
                return;
            }

            Utilizator user = _containerBL.UserBL.ReadByUsername(userName);
            if (!IsUserValid(userName, password, user))
            {
                return;
            }
            _containerBL.CurrentUser = user;
            if (user.Rol == Rol.Admin)
            {
                AdminMainForm adminMainForm = new AdminMainForm(_containerBL);
                adminMainForm.Show();
                this.Hide();
                return;
            }
            UserMainForm userMainFrom = new UserMainForm(_containerBL);
            userMainFrom.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
