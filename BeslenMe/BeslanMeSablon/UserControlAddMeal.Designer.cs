
namespace BeslanMeSablon
{
    partial class UserControlAddMeal
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
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.dgvFoodData = new System.Windows.Forms.DataGridView();
            this.picForCategories = new System.Windows.Forms.PictureBox();
            this.dtSelectDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelectMeals = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSelectedFoods = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedFoods)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchFood.Location = new System.Drawing.Point(1015, 24);
            this.txtSearchFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(165, 23);
            this.txtSearchFood.TabIndex = 0;
            this.txtSearchFood.TextChanged += new System.EventHandler(this.txtSearchFood_TextChanged);
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMeal.Location = new System.Drawing.Point(961, 553);
            this.btnAddMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(211, 39);
            this.btnAddMeal.TabIndex = 1;
            this.btnAddMeal.Text = "Öğün Ekle";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // dgvFoodData
            // 
            this.dgvFoodData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodData.Location = new System.Drawing.Point(269, 71);
            this.dgvFoodData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFoodData.Name = "dgvFoodData";
            this.dgvFoodData.RowHeadersWidth = 51;
            this.dgvFoodData.RowTemplate.Height = 24;
            this.dgvFoodData.Size = new System.Drawing.Size(911, 288);
            this.dgvFoodData.TabIndex = 2;
            this.dgvFoodData.DoubleClick += new System.EventHandler(this.dgvFoodData_DoubleClick);
            this.dgvFoodData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvFoodData_MouseClick);
            // 
            // picForCategories
            // 
            this.picForCategories.Location = new System.Drawing.Point(28, 71);
            this.picForCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picForCategories.Name = "picForCategories";
            this.picForCategories.Size = new System.Drawing.Size(221, 251);
            this.picForCategories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picForCategories.TabIndex = 3;
            this.picForCategories.TabStop = false;
            // 
            // dtSelectDate
            // 
            this.dtSelectDate.CustomFormat = "(\"MM/dd/yyyy\")";
            this.dtSelectDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtSelectDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtSelectDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSelectDate.Location = new System.Drawing.Point(124, 22);
            this.dtSelectDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtSelectDate.Name = "dtSelectDate";
            this.dtSelectDate.Size = new System.Drawing.Size(204, 23);
            this.dtSelectDate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(888, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Besin/Yemek Ara";
            // 
            // cmbSelectMeals
            // 
            this.cmbSelectMeals.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSelectMeals.FormattingEnabled = true;
            this.cmbSelectMeals.Location = new System.Drawing.Point(598, 20);
            this.cmbSelectMeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSelectMeals.Name = "cmbSelectMeals";
            this.cmbSelectMeals.Size = new System.Drawing.Size(140, 25);
            this.cmbSelectMeals.TabIndex = 7;
            this.cmbSelectMeals.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSelectMeals_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(490, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Öğün Seçiniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tarih Seçiniz:";
            // 
            // dgvSelectedFoods
            // 
            this.dgvSelectedFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedFoods.Location = new System.Drawing.Point(48, 380);
            this.dgvSelectedFoods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSelectedFoods.Name = "dgvSelectedFoods";
            this.dgvSelectedFoods.RowHeadersWidth = 51;
            this.dgvSelectedFoods.RowTemplate.Height = 24;
            this.dgvSelectedFoods.Size = new System.Drawing.Size(1124, 153);
            this.dgvSelectedFoods.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(44, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seçilen Besinler:";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Location = new System.Drawing.Point(704, 553);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(211, 39);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // UserControlAddMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbSelectMeals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtSelectDate);
            this.Controls.Add(this.picForCategories);
            this.Controls.Add(this.dgvSelectedFoods);
            this.Controls.Add(this.dgvFoodData);
            this.Controls.Add(this.btnAddMeal);
            this.Controls.Add(this.txtSearchFood);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlAddMeal";
            this.Size = new System.Drawing.Size(1209, 610);
            this.Load += new System.EventHandler(this.UserControlAddMeal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedFoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.DataGridView dgvFoodData;
        private System.Windows.Forms.PictureBox picForCategories;
        private System.Windows.Forms.DateTimePicker dtSelectDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelectMeals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSelectedFoods;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Portion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protein;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fat;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalorieUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatagoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagories;
        private System.Windows.Forms.Button btnClear;
    }
}
