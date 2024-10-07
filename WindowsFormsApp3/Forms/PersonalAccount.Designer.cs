namespace WindowsFormsApp3.Forms
{
    partial class PersonalAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.backBt = new System.Windows.Forms.Button();
            this.toСhangePassBt = new System.Windows.Forms.Button();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Личный кабинет";
            // 
            // backBt
            // 
            this.backBt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.backBt.Location = new System.Drawing.Point(617, 9);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(75, 23);
            this.backBt.TabIndex = 1;
            this.backBt.Text = "Назад";
            this.backBt.UseVisualStyleBackColor = false;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // toСhangePassBt
            // 
            this.toСhangePassBt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toСhangePassBt.Location = new System.Drawing.Point(428, 209);
            this.toСhangePassBt.Name = "toСhangePassBt";
            this.toСhangePassBt.Size = new System.Drawing.Size(75, 23);
            this.toСhangePassBt.TabIndex = 13;
            this.toСhangePassBt.Text = "Изменить";
            this.toСhangePassBt.UseVisualStyleBackColor = false;
            this.toСhangePassBt.Click += new System.EventHandler(this.toСhangePassBt_Click);
            // 
            // passwordTb
            // 
            this.passwordTb.Enabled = false;
            this.passwordTb.Location = new System.Drawing.Point(299, 212);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(123, 20);
            this.passwordTb.TabIndex = 11;
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Location = new System.Drawing.Point(248, 214);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(45, 13);
            this.labelPassword2.TabIndex = 10;
            this.labelPassword2.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Изменение личной информации о пльзователе";
            // 
            // exitBt
            // 
            this.exitBt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exitBt.Location = new System.Drawing.Point(707, 9);
            this.exitBt.Name = "exitBt";
            this.exitBt.Size = new System.Drawing.Size(75, 23);
            this.exitBt.TabIndex = 14;
            this.exitBt.Text = "Выход";
            this.exitBt.UseVisualStyleBackColor = false;
            this.exitBt.Click += new System.EventHandler(this.exitBt_Click);
            // 
            // PersonalAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBt);
            this.Controls.Add(this.toСhangePassBt);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.labelPassword2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.label1);
            this.Name = "PersonalAccount";
            this.Text = "PersonalAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Button toСhangePassBt;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitBt;
    }
}