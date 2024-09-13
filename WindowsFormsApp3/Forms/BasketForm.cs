using Beauty.modals;
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
    public partial class BasketForm : Form
    {
        public BasketForm()
        {
            InitializeComponent();
        }

        private void BasketForm_Load(object sender, EventArgs e)
        {
            int startPositionX = 33;
            int startPostitionY = 224;
            int offset = 50;
            int currentPositionY = startPostitionY - offset;

            foreach (var item in Basket.Items)
            {
                Label label5 = new Label();
                label5.AutoSize = true;
                label5.Location = new System.Drawing.Point(3, 26);
                label5.Name = "label5";
                label5.Size = new System.Drawing.Size(35, 13);
                label5.TabIndex = 0;
                label5.Text = item.MasterName;


                Label label6 = new Label();
                label6.AutoSize = true;
                label6.Location = new System.Drawing.Point(132, 26);
                label6.Name = "label6";
                label6.Size = new System.Drawing.Size(35, 13);
                label6.TabIndex = 1;
                label6.Text = item.Service.Name;

                Label label7 = new Label();
                label7.AutoSize = true;
                label7.Location = new System.Drawing.Point(262, 26);
                label7.Name = "label7";
                label7.Size = new System.Drawing.Size(35, 13);
                label7.TabIndex = 2;
                label7.Text = item.Time.ToString();

                Label label8 = new Label();
                label8.AutoSize = true;
                label8.Location = new System.Drawing.Point(400, 26);
                label8.Name = "label8";
                label8.Size = new System.Drawing.Size(35, 13);
                label8.TabIndex = 3;
                label8.Text = item.Service.Price.ToString();

                currentPositionY += offset;

                Panel panel1 = new System.Windows.Forms.Panel();
                panel1.Controls.Add(label8);
                panel1.Controls.Add(label7);
                panel1.Controls.Add(label6);
                panel1.Controls.Add(label5);
                panel1.Location = new System.Drawing.Point(startPositionX, currentPositionY);
                panel1.Name = "panel1";
                panel1.Size = new System.Drawing.Size(450, 69);
                panel1.TabIndex = 8;

                this.Controls.Add(panel1);
            }

            this.totalLb.Location = new System.Drawing.Point(450, currentPositionY+70);
            this.totalSumLb.Location = new System.Drawing.Point(500, currentPositionY + 70);
            this.totalSumLb.Text = Basket.TotalPrice.ToString();

        }

        private void exitBt2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
