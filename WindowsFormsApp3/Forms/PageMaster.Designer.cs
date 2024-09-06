namespace WindowsFormsApp3
{
    partial class PageMaster
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
            this.button1Exit = new System.Windows.Forms.Button();
            this.button1Back = new System.Windows.Forms.Button();
            this.label1Name = new System.Windows.Forms.Label();
            this.label1NameMaster = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3Price = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4Age = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5Experience = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.serviceLB = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1Exit
            // 
            this.button1Exit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1Exit.Location = new System.Drawing.Point(853, 25);
            this.button1Exit.Margin = new System.Windows.Forms.Padding(2);
            this.button1Exit.Name = "button1Exit";
            this.button1Exit.Size = new System.Drawing.Size(78, 24);
            this.button1Exit.TabIndex = 0;
            this.button1Exit.Text = "Выход";
            this.button1Exit.UseVisualStyleBackColor = false;
            this.button1Exit.Click += new System.EventHandler(this.button1Exit_Click);
            // 
            // button1Back
            // 
            this.button1Back.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1Back.Location = new System.Drawing.Point(759, 25);
            this.button1Back.Margin = new System.Windows.Forms.Padding(2);
            this.button1Back.Name = "button1Back";
            this.button1Back.Size = new System.Drawing.Size(81, 24);
            this.button1Back.TabIndex = 1;
            this.button1Back.Text = "Назад";
            this.button1Back.UseVisualStyleBackColor = false;
            this.button1Back.Click += new System.EventHandler(this.button1Back_Click);
            // 
            // label1Name
            // 
            this.label1Name.AutoSize = true;
            this.label1Name.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1Name.Location = new System.Drawing.Point(471, 153);
            this.label1Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1Name.Name = "label1Name";
            this.label1Name.Size = new System.Drawing.Size(37, 16);
            this.label1Name.TabIndex = 2;
            this.label1Name.Text = "Имя:";
            // 
            // label1NameMaster
            // 
            this.label1NameMaster.AutoSize = true;
            this.label1NameMaster.Location = new System.Drawing.Point(504, 153);
            this.label1NameMaster.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1NameMaster.Name = "label1NameMaster";
            this.label1NameMaster.Size = new System.Drawing.Size(35, 13);
            this.label1NameMaster.TabIndex = 3;
            this.label1NameMaster.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 340);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Услуги:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(809, 616);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(313, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Стоимость:";
            // 
            // label3Price
            // 
            this.label3Price.AutoSize = true;
            this.label3Price.Location = new System.Drawing.Point(313, 369);
            this.label3Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3Price.Name = "label3Price";
            this.label3Price.Size = new System.Drawing.Size(0, 13);
            this.label3Price.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(471, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Возраст:";
            // 
            // label4Age
            // 
            this.label4Age.AutoSize = true;
            this.label4Age.Location = new System.Drawing.Point(525, 179);
            this.label4Age.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4Age.Name = "label4Age";
            this.label4Age.Size = new System.Drawing.Size(35, 13);
            this.label4Age.TabIndex = 12;
            this.label4Age.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(471, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Опыт работы:";
            // 
            // label5Experience
            // 
            this.label5Experience.AutoSize = true;
            this.label5Experience.Location = new System.Drawing.Point(557, 207);
            this.label5Experience.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5Experience.Name = "label5Experience";
            this.label5Experience.Size = new System.Drawing.Size(35, 13);
            this.label5Experience.TabIndex = 14;
            this.label5Experience.Text = "label5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(607, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 24);
            this.button1.TabIndex = 15;
            this.button1.Text = "Перейти в корзину";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.button1Exit);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button1Back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 73);
            this.panel1.TabIndex = 16;
            // 
            // serviceLB
            // 
            this.serviceLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceLB.FormattingEnabled = true;
            this.serviceLB.ItemHeight = 18;
            this.serviceLB.Location = new System.Drawing.Point(12, 369);
            this.serviceLB.Name = "serviceLB";
            this.serviceLB.Size = new System.Drawing.Size(411, 184);
            this.serviceLB.TabIndex = 17;
            this.serviceLB.SelectedIndexChanged += new System.EventHandler(this.serviceLB_SelectedIndexChanged);
            // 
            // PageMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(939, 593);
            this.Controls.Add(this.serviceLB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5Experience);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label4Age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label3Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1NameMaster);
            this.Controls.Add(this.label1Name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PageMaster";
            this.Text = "PageMaster";
            this.Load += new System.EventHandler(this.PageMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Exit;
        private System.Windows.Forms.Button button1Back;
        private System.Windows.Forms.Label label1Name;
        private System.Windows.Forms.Label label1NameMaster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4Age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5Experience;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox serviceLB;
    }
}