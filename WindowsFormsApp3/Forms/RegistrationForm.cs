using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class RegistrationForm : Form
    {
        private Form _form;

        public RegistrationForm(Form form)
        {
            InitializeComponent();

            _form = form;
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            string login = loginTb.Text;
            string password = passwordTb.Text; 
            string repeatPassword = repeatPasswordTb.Text;
            string name = nameTb.Text;
            string email = emailTb.Text;

            if (password != repeatPassword)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            if (UserManager.IsUserExist(login))
            {
                MessageBox.Show("Логин занят");
                return;
            }

            UserManager.Registration(login, password, name, email);

            MessageBox.Show("Вы успешно зарегистрировались");
            GoBack();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void GoBack()
        {
            this.Close();
            _form.Show();
        }
    }
}
