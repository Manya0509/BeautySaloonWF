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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;

            string masterName = panel.Name.Substring(panel.Name.IndexOf("_") + 1);

            this.Hide();
            new PageMaster(this).Show();
        }

        private void buttonExit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
