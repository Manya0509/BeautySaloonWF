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
            this.buttonEntrancePA1 = new System.Windows.Forms.Button();
            this.buttonChangePassword1 = new System.Windows.Forms.Button();
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
            // buttonEntrancePA1
            // 
            this.buttonEntrancePA1.Location = new System.Drawing.Point(244, 137);
            this.buttonEntrancePA1.Name = "buttonEntrancePA1";
            this.buttonEntrancePA1.Size = new System.Drawing.Size(231, 40);
            this.buttonEntrancePA1.TabIndex = 2;
            this.buttonEntrancePA1.Text = "Вход в личный кабинет";
            this.buttonEntrancePA1.UseVisualStyleBackColor = true;
            this.buttonEntrancePA1.Click += new System.EventHandler(this.buttonEntrancePA1_Click);
            // 
            // buttonChangePassword1
            // 
            this.buttonChangePassword1.Location = new System.Drawing.Point(244, 221);
            this.buttonChangePassword1.Name = "buttonChangePassword1";
            this.buttonChangePassword1.Size = new System.Drawing.Size(231, 40);
            this.buttonChangePassword1.TabIndex = 3;
            this.buttonChangePassword1.Text = "Изменить пароль";
            this.buttonChangePassword1.UseVisualStyleBackColor = true;
            // 
            // PersonalAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChangePassword1);
            this.Controls.Add(this.buttonEntrancePA1);
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
        private System.Windows.Forms.Button buttonEntrancePA1;
        private System.Windows.Forms.Button buttonChangePassword1;
    }
}