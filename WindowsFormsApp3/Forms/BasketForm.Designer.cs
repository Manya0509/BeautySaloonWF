﻿namespace WindowsFormsApp3.Forms
{
    partial class BasketForm
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
            this.backBt1 = new System.Windows.Forms.Button();
            this.exitBt2 = new System.Windows.Forms.Button();
            this.totalLb = new System.Windows.Forms.Label();
            this.totalSumLb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBt1
            // 
            this.backBt1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.backBt1.Location = new System.Drawing.Point(13, 13);
            this.backBt1.Name = "backBt1";
            this.backBt1.Size = new System.Drawing.Size(75, 23);
            this.backBt1.TabIndex = 0;
            this.backBt1.Text = "Назад";
            this.backBt1.UseVisualStyleBackColor = false;
            // 
            // exitBt2
            // 
            this.exitBt2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exitBt2.Location = new System.Drawing.Point(715, 17);
            this.exitBt2.Margin = new System.Windows.Forms.Padding(2);
            this.exitBt2.Name = "exitBt2";
            this.exitBt2.Size = new System.Drawing.Size(83, 19);
            this.exitBt2.TabIndex = 2;
            this.exitBt2.Text = "Выход";
            this.exitBt2.UseVisualStyleBackColor = false;
            this.exitBt2.Click += new System.EventHandler(this.exitBt2_Click);
            // 
            // totalLb
            // 
            this.totalLb.AutoSize = true;
            this.totalLb.Location = new System.Drawing.Point(331, 228);
            this.totalLb.Name = "totalLb";
            this.totalLb.Size = new System.Drawing.Size(37, 13);
            this.totalLb.TabIndex = 8;
            this.totalLb.Text = "Итого";
            // 
            // totalSumLb
            // 
            this.totalSumLb.AutoSize = true;
            this.totalSumLb.Location = new System.Drawing.Point(420, 228);
            this.totalSumLb.Name = "totalSumLb";
            this.totalSumLb.Size = new System.Drawing.Size(0, 13);
            this.totalSumLb.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя мастера";
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 497);
            this.Controls.Add(this.totalSumLb);
            this.Controls.Add(this.totalLb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBt2);
            this.Controls.Add(this.backBt1);
            this.Name = "BasketForm";
            this.Text = "BasketForm";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.BasketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBt1;
        private System.Windows.Forms.Button exitBt2;
        private System.Windows.Forms.Label totalLb;
        private System.Windows.Forms.Label totalSumLb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}