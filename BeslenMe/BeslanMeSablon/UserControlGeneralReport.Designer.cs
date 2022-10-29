
namespace BeslanMeSablon
{
    partial class UserControlGeneralReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMostSelectedFood = new System.Windows.Forms.Button();
            this.dgvQuery = new System.Windows.Forms.DataGridView();
            this.dtpFirstDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSecondDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMeals = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(545, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Genel Rapor Bilgisi :";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(238, 349);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(265, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "Öğün Bazlı Arama";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMostSelectedFood
            // 
            this.btnMostSelectedFood.Location = new System.Drawing.Point(238, 467);
            this.btnMostSelectedFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostSelectedFood.Name = "btnMostSelectedFood";
            this.btnMostSelectedFood.Size = new System.Drawing.Size(265, 50);
            this.btnMostSelectedFood.TabIndex = 7;
            this.btnMostSelectedFood.Text = "Genel Arama";
            this.btnMostSelectedFood.UseVisualStyleBackColor = true;
            this.btnMostSelectedFood.Click += new System.EventHandler(this.btnMostSelectedFood_Click);
            // 
            // dgvQuery
            // 
            this.dgvQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuery.Location = new System.Drawing.Point(549, 139);
            this.dgvQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQuery.Name = "dgvQuery";
            this.dgvQuery.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvQuery.RowTemplate.Height = 24;
            this.dgvQuery.Size = new System.Drawing.Size(586, 378);
            this.dgvQuery.TabIndex = 3;
            // 
            // dtpFirstDate
            // 
            this.dtpFirstDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpFirstDate.Location = new System.Drawing.Point(238, 141);
            this.dtpFirstDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFirstDate.Name = "dtpFirstDate";
            this.dtpFirstDate.Size = new System.Drawing.Size(265, 23);
            this.dtpFirstDate.TabIndex = 9;
            // 
            // dtpSecondDate
            // 
            this.dtpSecondDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSecondDate.Location = new System.Drawing.Point(238, 200);
            this.dtpSecondDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSecondDate.Name = "dtpSecondDate";
            this.dtpSecondDate.Size = new System.Drawing.Size(265, 23);
            this.dtpSecondDate.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(78, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Başlangıç Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(120, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bitiş Tarihi:";
            // 
            // cmbMeals
            // 
            this.cmbMeals.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMeals.FormattingEnabled = true;
            this.cmbMeals.Location = new System.Drawing.Point(238, 259);
            this.cmbMeals.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMeals.Name = "cmbMeals";
            this.cmbMeals.Size = new System.Drawing.Size(265, 25);
            this.cmbMeals.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(114, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Öğün Seç:";
            // 
            // UserControlGeneralReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMeals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpSecondDate);
            this.Controls.Add(this.dtpFirstDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnMostSelectedFood);
            this.Controls.Add(this.dgvQuery);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlGeneralReport";
            this.Size = new System.Drawing.Size(1209, 610);
            this.Load += new System.EventHandler(this.UserControlGeneralReport_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMostSelectedFood;
        private System.Windows.Forms.DataGridView dgvQuery;
        private System.Windows.Forms.DateTimePicker dtpFirstDate;
        private System.Windows.Forms.DateTimePicker dtpSecondDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMeals;
        private System.Windows.Forms.Label label4;
    }
}
