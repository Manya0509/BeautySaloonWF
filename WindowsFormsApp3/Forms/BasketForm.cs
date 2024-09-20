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
            UpdateBasket();

        }

        private void UpdateBasket()
        {
            int startPositionX = 33;
            int startPostitionY = 100;
            int offset = 50;
            int currentPositionY = startPostitionY - offset;

            foreach (var item in Basket.Items)
            {
                var label5 = new Label();
                label5.AutoSize = true;
                label5.Location = new System.Drawing.Point(3, 26);
                label5.Name = "label5";
                label5.Size = new System.Drawing.Size(35, 13);
                label5.TabIndex = 0;
                label5.Text = item.MasterName;

                var label6 = new Label();
                label6.AutoSize = true;
                label6.Location = new System.Drawing.Point(132, 26);
                label6.Name = "label6";
                label6.Size = new System.Drawing.Size(35, 13);
                label6.TabIndex = 1;
                label6.Text = item.Service.Name;

                var label7 = new Label();
                label7.AutoSize = true;
                label7.Location = new System.Drawing.Point(262, 26);
                label7.Name = "label7";
                label7.Size = new System.Drawing.Size(35, 13);
                label7.TabIndex = 2;
                label7.Text = item.Time.ToString();

                var label8 = new Label();
                label8.AutoSize = true;
                label8.Location = new System.Drawing.Point(400, 26);
                label8.Name = "label8";
                label8.Size = new System.Drawing.Size(35, 13);
                label8.TabIndex = 3;
                label8.Text = item.Service.Price.ToString();

                var button = new Button();
                button.Location = new System.Drawing.Point(440, 26);
                button.Name = $"{item.Id}?button1";
                button.Size = new System.Drawing.Size(75, 23);
                button.TabIndex = 10;
                button.Text = "button1";
                button.Click += new System.EventHandler(RemoveBtn_Click);
                button.UseVisualStyleBackColor = true;

                currentPositionY += offset;

                var panel1 = new System.Windows.Forms.Panel();
                panel1.Controls.Add(label8);
                panel1.Controls.Add(label7);
                panel1.Controls.Add(label6);
                panel1.Controls.Add(label5);
                panel1.Controls.Add(button);
                panel1.Location = new System.Drawing.Point(startPositionX, currentPositionY);
                panel1.Name = "panel1";
                panel1.Size = new System.Drawing.Size(600, 69);
                panel1.TabIndex = 8;

                this.Controls.Add(panel1);
            }

            this.totalLb.Location = new System.Drawing.Point(450, currentPositionY + 70);
            this.totalSumLb.Location = new System.Drawing.Point(500, currentPositionY + 70);
            this.totalSumLb.Text = Basket.TotalPrice.ToString();
        }

        private void RemoveBasket()
        {
            var panels = this.Controls.Find("panel1", true);

            foreach (var item in panels)
            {
                this.Controls.Remove(item);
            }
        }

        private void exitBt2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            string payingInfoId = button.Name.Substring(0, button.Name.IndexOf('?'));

            var payingInfo = Basket.Items.FirstOrDefault(x => x.Id == payingInfoId);

            Basket.Items.Remove(payingInfo);

            RemoveBasket();

            UpdateBasket();
        }
    }
}
