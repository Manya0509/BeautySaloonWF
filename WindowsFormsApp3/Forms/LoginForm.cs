using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Forms;

namespace WindowsFormsApp3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string login = loginTb.Text;
            string password = passwordTb.Text;

            if (UserManager.IsUserLogin(login, password))
            {
                MessageBox.Show("Успешно");
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }

        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegistrationForm(this).Show();
        }
    }
}
