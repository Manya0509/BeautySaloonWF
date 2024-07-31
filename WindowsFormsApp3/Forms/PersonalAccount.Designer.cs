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
            this.buttonBack1 = new System.Windows.Forms.Button();
            this.buttonToСhangePass = new System.Windows.Forms.Button();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // buttonBack1
            // 
            this.buttonBack1.Location = new System.Drawing.Point(713, 12);
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Size = new System.Drawing.Size(75, 23);
            this.buttonBack1.TabIndex = 1;
            this.buttonBack1.Text = "Назад";
            this.buttonBack1.UseVisualStyleBackColor = true;
            this.buttonBack1.Click += new System.EventHandler(this.buttonBack1_Click);
            // 
            // buttonToСhangePass
            // 
            this.buttonToСhangePass.Location = new System.Drawing.Point(405, 214);
            this.buttonToСhangePass.Name = "buttonToСhangePass";
            this.buttonToСhangePass.Size = new System.Drawing.Size(75, 23);
            this.buttonToСhangePass.TabIndex = 13;
            this.buttonToСhangePass.Text = "Изменить";
            this.buttonToСhangePass.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Location = new System.Drawing.Point(299, 212);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword1.TabIndex = 11;
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Location = new System.Drawing.Point(248, 219);
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
            // PersonalAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonToСhangePass);
            this.Controls.Add(this.textBoxPassword1);
            this.Controls.Add(this.labelPassword2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBack1);
            this.Controls.Add(this.label1);
            this.Name = "PersonalAccount";
            this.Text = "PersonalAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack1;
        private System.Windows.Forms.Button buttonToСhangePass;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.Label label2;
    }
}