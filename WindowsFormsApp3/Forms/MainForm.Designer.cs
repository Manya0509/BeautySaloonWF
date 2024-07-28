namespace WindowsFormsApp3.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.barberPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.servicesLb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.workExpirienceLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ageLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fioLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CosmetologistPage = new System.Windows.Forms.TabPage();
            this.lashmakerPage = new System.Windows.Forms.TabPage();
            this.visagistPage = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.barberPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.barberPage);
            this.tabControl1.Controls.Add(this.CosmetologistPage);
            this.tabControl1.Controls.Add(this.lashmakerPage);
            this.tabControl1.Controls.Add(this.visagistPage);
            this.tabControl1.Location = new System.Drawing.Point(32, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(825, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // barberPage
            // 
            this.barberPage.Controls.Add(this.panel1);
            this.barberPage.Location = new System.Drawing.Point(4, 22);
            this.barberPage.Name = "barberPage";
            this.barberPage.Padding = new System.Windows.Forms.Padding(3);
            this.barberPage.Size = new System.Drawing.Size(817, 434);
            this.barberPage.TabIndex = 0;
            this.barberPage.Text = "Барбер";
            this.barberPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 412);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.servicesLb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.workExpirienceLb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ageLb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.fioLb);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 116);
            this.panel2.TabIndex = 0;
            // 
            // servicesLb
            // 
            this.servicesLb.AutoSize = true;
            this.servicesLb.Location = new System.Drawing.Point(212, 54);
            this.servicesLb.Name = "servicesLb";
            this.servicesLb.Size = new System.Drawing.Size(0, 13);
            this.servicesLb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Услуги: ";
            // 
            // workExpirienceLb
            // 
            this.workExpirienceLb.AutoSize = true;
            this.workExpirienceLb.Location = new System.Drawing.Point(250, 37);
            this.workExpirienceLb.Name = "workExpirienceLb";
            this.workExpirienceLb.Size = new System.Drawing.Size(0, 13);
            this.workExpirienceLb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Опыт работы";
            // 
            // ageLb
            // 
            this.ageLb.AutoSize = true;
            this.ageLb.Location = new System.Drawing.Point(212, 20);
            this.ageLb.Name = "ageLb";
            this.ageLb.Size = new System.Drawing.Size(0, 13);
            this.ageLb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Возраст";
            // 
            // fioLb
            // 
            this.fioLb.AutoSize = true;
            this.fioLb.Location = new System.Drawing.Point(209, 4);
            this.fioLb.Name = "fioLb";
            this.fioLb.Size = new System.Drawing.Size(0, 13);
            this.fioLb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО:";
            // 
            // CosmetologistPage
            // 
            this.CosmetologistPage.Location = new System.Drawing.Point(4, 22);
            this.CosmetologistPage.Name = "CosmetologistPage";
            this.CosmetologistPage.Padding = new System.Windows.Forms.Padding(3);
            this.CosmetologistPage.Size = new System.Drawing.Size(817, 434);
            this.CosmetologistPage.TabIndex = 1;
            this.CosmetologistPage.Text = "Косметолог";
            this.CosmetologistPage.UseVisualStyleBackColor = true;
            // 
            // lashmakerPage
            // 
            this.lashmakerPage.Location = new System.Drawing.Point(4, 22);
            this.lashmakerPage.Name = "lashmakerPage";
            this.lashmakerPage.Size = new System.Drawing.Size(817, 434);
            this.lashmakerPage.TabIndex = 2;
            this.lashmakerPage.Text = "Лэшмейкер";
            this.lashmakerPage.UseVisualStyleBackColor = true;
            // 
            // visagistPage
            // 
            this.visagistPage.Location = new System.Drawing.Point(4, 22);
            this.visagistPage.Name = "visagistPage";
            this.visagistPage.Size = new System.Drawing.Size(817, 434);
            this.visagistPage.TabIndex = 3;
            this.visagistPage.Text = "Визажист";
            this.visagistPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(156, 110);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.png_transparent_shopping_cart_icon_shopping_cart_black_design_trade_thumbnail;
            this.pictureBox2.Location = new System.Drawing.Point(975, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.лк;
            this.pictureBox1.Location = new System.Drawing.Point(1034, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 585);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.barberPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage barberPage;
        private System.Windows.Forms.TabPage CosmetologistPage;
        private System.Windows.Forms.TabPage lashmakerPage;
        private System.Windows.Forms.TabPage visagistPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label workExpirienceLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ageLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fioLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label servicesLb;
    }
}