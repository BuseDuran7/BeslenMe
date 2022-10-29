
namespace BeslanMeSablon
{
    partial class UserControlCalcCalPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchForFood = new System.Windows.Forms.TextBox();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.btnClean = new System.Windows.Forms.Button();
            this.dgvSelected = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(961, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yemek Adı:";
            // 
            // txtSearchForFood
            // 
            this.txtSearchForFood.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchForFood.Location = new System.Drawing.Point(1067, 18);
            this.txtSearchForFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchForFood.Name = "txtSearchForFood";
            this.txtSearchForFood.Size = new System.Drawing.Size(117, 23);
            this.txtSearchForFood.TabIndex = 3;
            this.txtSearchForFood.TextChanged += new System.EventHandler(this.txtSearchForFood_TextChanged);
            // 
            // dgvFoods
            // 
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Location = new System.Drawing.Point(15, 18);
            this.dgvFoods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.RowHeadersWidth = 51;
            this.dgvFoods.RowTemplate.Height = 24;
            this.dgvFoods.Size = new System.Drawing.Size(909, 273);
            this.dgvFoods.TabIndex = 4;
            this.dgvFoods.DoubleClick += new System.EventHandler(this.dgvFoods_DoubleClick);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClean.Location = new System.Drawing.Point(1067, 545);
            this.btnClean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(117, 32);
            this.btnClean.TabIndex = 5;
            this.btnClean.Text = "Temizle";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // dgvSelected
            // 
            this.dgvSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelected.Location = new System.Drawing.Point(15, 310);
            this.dgvSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSelected.Name = "dgvSelected";
            this.dgvSelected.RowHeadersWidth = 51;
            this.dgvSelected.RowTemplate.Height = 24;
            this.dgvSelected.Size = new System.Drawing.Size(909, 267);
            this.dgvSelected.TabIndex = 9;
            // 
            // UserControlCalcCalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSelected);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.dgvFoods);
            this.Controls.Add(this.txtSearchForFood);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlCalcCalPage";
            this.Size = new System.Drawing.Size(1209, 610);
            this.Load += new System.EventHandler(this.UserControlCalcCalPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchForFood;
        private System.Windows.Forms.DataGridView dgvFoods;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridView dgvSelected;
    }
}
