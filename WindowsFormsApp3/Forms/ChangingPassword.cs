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
    public partial class ChangingPassword : Form
    {
        public ChangingPassword()
        {
            InitializeComponent();
        }

        private void buttonToСhangeLog1_Click(object sender, EventArgs e)
        {
            if (buttonToСhangeLog1.Text =="Изменить")
            {
                textBoxLogin1.Enabled = true;
                buttonToСhangeLog1.Text = "Сохранить";
            }
        }

        private void buttonToСhangePass_Click(object sender, EventArgs e)
        {
            if (buttonToСhangePass.Text == "Изменить")
            {
                textBoxPassword1.Enabled = true;
                buttonToСhangePass.Text = "Сохранить";
            }

        }
    }
}
