using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class PageMaster : Form
    {
        private Form _form;

        public PageMaster(Form form)
        {
            InitializeComponent();
            _form = form;
        }
        private void button1Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1Back_Click(object sender, EventArgs e)
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


