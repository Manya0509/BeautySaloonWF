namespace WindowsFormsApp3.Forms
{
    partial class ChangingPassword
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin1 = new System.Windows.Forms.TextBox();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.buttonToСhangeLog1 = new System.Windows.Forms.Button();
            this.buttonToСhangePass = new System.Windows.Forms.Button();
            this.buttonBack1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Изменение личной информации о пльзователе";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(329, 119);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Логин";
            // 
            // textBoxLogin1
            // 
            this.textBoxLogin1.Location = new System.Drawing.Point(373, 112);
            this.textBoxLogin1.Name = "textBoxLogin1";
            this.textBoxLogin1.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin1.TabIndex = 2;
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Location = new System.Drawing.Point(322, 175);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(45, 13);
            this.labelPassword2.TabIndex = 3;
            this.labelPassword2.Text = "Пароль";
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Location = new System.Drawing.Point(373, 168);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword1.TabIndex = 4;
            // 
            // buttonToСhangeLog1
            // 
            this.buttonToСhangeLog1.Location = new System.Drawing.Point(479, 112);
            this.buttonToСhangeLog1.Name = "buttonToСhangeLog1";
            this.buttonToСhangeLog1.Size = new System.Drawing.Size(75, 23);
            this.buttonToСhangeLog1.TabIndex = 5;
            this.buttonToСhangeLog1.Text = "Изменить";
            this.buttonToСhangeLog1.UseVisualStyleBackColor = true;
            this.buttonToСhangeLog1.Click += new System.EventHandler(this.buttonToСhangeLog1_Click);
            // 
            // buttonToСhangePass
            // 
            this.buttonToСhangePass.Location = new System.Drawing.Point(479, 170);
            this.buttonToСhangePass.Name = "buttonToСhangePass";
            this.buttonToСhangePass.Size = new System.Drawing.Size(75, 23);
            this.buttonToСhangePass.TabIndex = 6;
            this.buttonToСhangePass.Text = "Изменить";
            this.buttonToСhangePass.UseVisualStyleBackColor = true;
            this.buttonToСhangePass.Click += new System.EventHandler(this.buttonToСhangePass_Click);
            // 
            // buttonBack1
            // 
            this.buttonBack1.Location = new System.Drawing.Point(713, 12);
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Size = new System.Drawing.Size(75, 23);
            this.buttonBack1.TabIndex = 7;
            this.buttonBack1.Text = "Назад";
            this.buttonBack1.UseVisualStyleBackColor = true;
            // 
            // ChangingPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack1);
            this.Controls.Add(this.buttonToСhangePass);
            this.Controls.Add(this.buttonToСhangeLog1);
            this.Controls.Add(this.textBoxPassword1);
            this.Controls.Add(this.labelPassword2);
            this.Controls.Add(this.textBoxLogin1);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.label1);
            this.Name = "ChangingPassword";
            this.Text = "ChangingPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin1;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.Button buttonToСhangeLog1;
        private System.Windows.Forms.Button buttonToСhangePass;
        private System.Windows.Forms.Button buttonBack1;
    }
}