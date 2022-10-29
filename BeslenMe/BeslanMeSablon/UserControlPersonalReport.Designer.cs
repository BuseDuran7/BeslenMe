
namespace BeslanMeSablon
{
    partial class UserControlPersonalReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbMeals = new System.Windows.Forms.ComboBox();
            this.dtpSecondDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFirstDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEatenFoods = new System.Windows.Forms.DataGridView();
            this.btnShowEatenFoods = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEatenFoods)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMeals
            // 
            this.cmbMeals.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMeals.FormattingEnabled = true;
            this.cmbMeals.Location = new System.Drawing.Point(848, 43);
            this.cmbMeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMeals.Name = "cmbMeals";
            this.cmbMeals.Size = new System.Drawing.Size(167, 25);
            this.cmbMeals.TabIndex = 7;
            this.cmbMeals.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMeals_KeyDown);
            // 
            // dtpSecondDate
            // 
            this.dtpSecondDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSecondDate.Location = new System.Drawing.Point(480, 48);
            this.dtpSecondDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpSecondDate.Name = "dtpSecondDate";
            this.dtpSecondDate.Size = new System.Drawing.Size(223, 23);
            this.dtpSecondDate.TabIndex = 5;
            // 
            // dtpFirstDate
            // 
            this.dtpFirstDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpFirstDate.Location = new System.Drawing.Point(131, 48);
            this.dtpFirstDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFirstDate.Name = "dtpFirstDate";
            this.dtpFirstDate.Size = new System.Drawing.Size(223, 23);
            this.dtpFirstDate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(734, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Öğün Seçimi :";
            // 
            // dgvEatenFoods
            // 
            this.dgvEatenFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEatenFoods.Location = new System.Drawing.Point(34, 211);
            this.dgvEatenFoods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEatenFoods.Name = "dgvEatenFoods";
            this.dgvEatenFoods.RowHeadersWidth = 51;
            this.dgvEatenFoods.RowTemplate.Height = 24;
            this.dgvEatenFoods.Size = new System.Drawing.Size(1156, 384);
            this.dgvEatenFoods.TabIndex = 8;
            // 
            // btnShowEatenFoods
            // 
            this.btnShowEatenFoods.Location = new System.Drawing.Point(1025, 41);
            this.btnShowEatenFoods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowEatenFoods.Name = "btnShowEatenFoods";
            this.btnShowEatenFoods.Size = new System.Drawing.Size(160, 27);
            this.btnShowEatenFoods.TabIndex = 9;
            this.btnShowEatenFoods.Text = "Göster";
            this.btnShowEatenFoods.UseVisualStyleBackColor = true;
            this.btnShowEatenFoods.Click += new System.EventHandler(this.btnShowEatenFoods_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kişisel Rapor :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Başlangıç Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(399, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bitiş Tarihi:";
            // 
            // UserControlPersonalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnShowEatenFoods);
            this.Controls.Add(this.dgvEatenFoods);
            this.Controls.Add(this.cmbMeals);
            this.Controls.Add(this.dtpSecondDate);
            this.Controls.Add(this.dtpFirstDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlPersonalReport";
            this.Size = new System.Drawing.Size(1209, 610);
            this.Load += new System.EventHandler(this.UserControlPersonalReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEatenFoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMeals;
        private System.Windows.Forms.DateTimePicker dtpSecondDate;
        private System.Windows.Forms.DateTimePicker dtpFirstDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEatenFoods;
        private System.Windows.Forms.Button btnShowEatenFoods;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}
