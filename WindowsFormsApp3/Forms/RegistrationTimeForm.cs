using Beauty;
using Beauty.modals;
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
    public partial class RegistrationTimeForm : Form
    {
        private BeautyMaster _master;
        private Service _service;

        public RegistrationTimeForm(BeautyMaster master, Service service)
        {
            InitializeComponent();

            _master = master;
            _service = service;

            this.chooseBtn_8.Click += new System.EventHandler(this.TimeChooseBtn_Click);
            this.chooseBtn_9.Click += new System.EventHandler(this.TimeChooseBtn_Click);
            this.chooseBtn_10.Click += new System.EventHandler(this.TimeChooseBtn_Click);
            this.chooseBtn_11.Click += new System.EventHandler(this.TimeChooseBtn_Click);
            this.chooseBtn_12.Click += new System.EventHandler(this.TimeChooseBtn_Click);
            this.chooseBtn_13.Click += new System.EventHandler(this.TimeChooseBtn_Click);
            this.chooseBtn_14.Click += new System.EventHandler(this.TimeChooseBtn_Click);
            this.chooseBtn_15.Click += new System.EventHandler(this.TimeChooseBtn_Click);
        }

        private void TimeChooseBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (!btn.Enabled)
                return;

            int choosenTime = int.Parse(btn.Name.Substring(btn.Name.IndexOf("_") + 1));

            RegistrationTime time = _master.Times.FirstOrDefault(x => x.Time.Hour == choosenTime);

            time.isBuisy = true;
            btn.Enabled = false;

            PayingInfo payingInfo = new PayingInfo(
                _master.Name,
                time.Time,
                _service
            );

            Basket.Items.Add(payingInfo);
        }

        private void RegistrationTimeForm_Load(object sender, EventArgs e)
        {
            foreach (var item in _master.Times)
            {
                switch (item.Time.Hour)
                {
                    case 8:
                        if (item.isBuisy)
                            chooseBtn_8.Enabled = false;
                        break;
                    case 9:
                        if (item.isBuisy)
                            chooseBtn_9.Enabled = false;
                        break;
                    case 10:
                        if (item.isBuisy)
                            chooseBtn_10.Enabled = false;
                        break;
                    case 11:
                        if (item.isBuisy)
                            chooseBtn_11.Enabled = false;
                        break;
                    case 12:
                        if (item.isBuisy)
                            chooseBtn_12.Enabled = false;
                        break;
                    case 13:
                        if (item.isBuisy)
                            chooseBtn_13.Enabled = false;
                        break;
                    case 14:
                        if (item.isBuisy)
                            chooseBtn_14.Enabled = false;
                        break;
                    case 15:
                        if (item.isBuisy)
                            chooseBtn_15.Enabled = false;
                        break;

                    default:
                        break;
                }
            }
        }

        private void RegistrationTimeForm_Load_1(object sender, EventArgs e)
        {
            foreach (var item in _master.Times)
            {
                if (item.isBuisy)
                {
                    switch (item.Time.Hour)
                    {
                        case 8:
                            chooseBtn_8.Enabled = false; 
                            break;
                        case 9:
                            chooseBtn_9.Enabled = false;
                            break;
                        case 10:
                            chooseBtn_10.Enabled = false;
                            break;
                        case 11:
                            chooseBtn_11.Enabled = false;
                            break;
                        case 12:
                            chooseBtn_12.Enabled = false;
                            break;
                        case 13:
                            chooseBtn_13.Enabled = false;
                            break;
                        case 14:
                            chooseBtn_14.Enabled = false;
                            break;
                        case 15:
                            chooseBtn_15.Enabled = false;
                            break;
                    }
                }
            }
        }
    }
}
