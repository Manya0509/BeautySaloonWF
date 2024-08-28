using Beauty;
using BeautySaloon;
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
        private BeautyMaster _master;

        public PageMaster(Form form, BeautyMaster master)
        {
            InitializeComponent();
            _form = form;
            _master = master;
        }

        private void PageMaster_Load(object sender, EventArgs e)
        {
            label1NameMaster.Text = _master.Name;
            label4Age.Text = $"{_master.Age}";
            label5Experience.Text = $"{_master.WorkExperience}";
            //pictureBox1.Image = Image.FromFile(_master.ImagePath);

            foreach (var item in _master.Services)
            {
                label2NameOfService.Text += item.Name + "\n";
                label3Price.Text += item.Price + "\n";
            }



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

        private void button1Time_Click(object sender, EventArgs e)
        {
            new RegistrationTimeForm(_master).Show();
        }
    }
}


