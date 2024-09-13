using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class PersonalAccount : Form
    {
        private Form _form;
        public PersonalAccount(Form form)
        {
            InitializeComponent();
            _form = form;
        }

        private void buttonEntrancePA1_Click(object sender, EventArgs e)
        {
            
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void GoBack()
        {
            this.Hide();
            _form.Show();
        }

        private void exitBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
