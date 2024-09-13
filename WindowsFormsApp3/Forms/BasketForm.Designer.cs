namespace WindowsFormsApp3.Forms
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
            this.basketTable = new System.Windows.Forms.TableLayoutPanel();
            this.exitBt2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameMasCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiseCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBt1
            // 
            this.backBt1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.backBt1.Location = new System.Drawing.Point(20, 20);
            this.backBt1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backBt1.Name = "backBt1";
            this.backBt1.Size = new System.Drawing.Size(112, 35);
            this.backBt1.TabIndex = 0;
            this.backBt1.Text = "Назад";
            this.backBt1.UseVisualStyleBackColor = false;
            // 
            // basketTable
            // 
            this.basketTable.ColumnCount = 4;
            this.basketTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.64384F));
            this.basketTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.35616F));
            this.basketTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.basketTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.basketTable.Location = new System.Drawing.Point(20, 125);
            this.basketTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.basketTable.Name = "basketTable";
            this.basketTable.RowCount = 1;
            this.basketTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.basketTable.Size = new System.Drawing.Size(945, 97);
            this.basketTable.TabIndex = 1;
            // 
            // exitBt2
            // 
            this.exitBt2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exitBt2.Location = new System.Drawing.Point(1073, 26);
            this.exitBt2.Name = "exitBt2";
            this.exitBt2.Size = new System.Drawing.Size(124, 29);
            this.exitBt2.TabIndex = 2;
            this.exitBt2.Text = "Выход";
            this.exitBt2.UseVisualStyleBackColor = false;
            this.exitBt2.Click += new System.EventHandler(this.exitBt2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameMasCl,
            this.ServiseCl,
            this.TimeCl,
            this.PriceCl});
            this.dataGridView1.Location = new System.Drawing.Point(20, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(732, 82);
            this.dataGridView1.TabIndex = 3;
            // 
            // nameMasCl
            // 
            this.nameMasCl.HeaderText = "Имя мастера";
            this.nameMasCl.MinimumWidth = 8;
            this.nameMasCl.Name = "nameMasCl";
            this.nameMasCl.Width = 150;
            // 
            // ServiseCl
            // 
            this.ServiseCl.HeaderText = "Наименование услуги";
            this.ServiseCl.MinimumWidth = 8;
            this.ServiseCl.Name = "ServiseCl";
            this.ServiseCl.Width = 220;
            // 
            // TimeCl
            // 
            this.TimeCl.HeaderText = "Время";
            this.TimeCl.MinimumWidth = 8;
            this.TimeCl.Name = "TimeCl";
            this.TimeCl.Width = 150;
            // 
            // PriceCl
            // 
            this.PriceCl.HeaderText = "Стоимость";
            this.PriceCl.MinimumWidth = 8;
            this.PriceCl.Name = "PriceCl";
            this.PriceCl.Width = 150;
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1233, 765);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitBt2);
            this.Controls.Add(this.basketTable);
            this.Controls.Add(this.backBt1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BasketForm";
            this.Text = "BasketForm";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.BasketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBt1;
        private System.Windows.Forms.TableLayoutPanel basketTable;
        private System.Windows.Forms.Button exitBt2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMasCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiseCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCl;
    }
}