
namespace BeslanMeSablon
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.txtUserMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrWeight = new System.Windows.Forms.NumericUpDown();
            this.nmrHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblContains = new System.Windows.Forms.Label();
            this.btnContinueToMain = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserMail
            // 
            this.txtUserMail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserMail.Location = new System.Drawing.Point(163, 42);
            this.txtUserMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserMail.Name = "txtUserMail";
            this.txtUserMail.Size = new System.Drawing.Size(349, 24);
            this.txtUserMail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail:";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserPassword.Location = new System.Drawing.Point(163, 92);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(347, 24);
            this.txtUserPassword.TabIndex = 2;
            this.txtUserPassword.TextChanged += new System.EventHandler(this.txtUserPassword_TextChanged);
            this.txtUserPassword.Leave += new System.EventHandler(this.txtUserPassword_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // nmrWeight
            // 
            this.nmrWeight.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrWeight.Location = new System.Drawing.Point(192, 262);
            this.nmrWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrWeight.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nmrWeight.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nmrWeight.Name = "nmrWeight";
            this.nmrWeight.Size = new System.Drawing.Size(112, 23);
            this.nmrWeight.TabIndex = 4;
            this.nmrWeight.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // nmrHeight
            // 
            this.nmrHeight.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrHeight.Location = new System.Drawing.Point(192, 210);
            this.nmrHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrHeight.Maximum = new decimal(new int[] {
            220,
            0,
            0,
            0});
            this.nmrHeight.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nmrHeight.Name = "nmrHeight";
            this.nmrHeight.Size = new System.Drawing.Size(112, 23);
            this.nmrHeight.TabIndex = 3;
            this.nmrHeight.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(101, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Boy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(103, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kilo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(63, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cinsiyet:";
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBirthDate.Location = new System.Drawing.Point(192, 321);
            this.dtBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(320, 23);
            this.dtBirthDate.TabIndex = 5;
            this.dtBirthDate.ValueChanged += new System.EventHandler(this.dtBirthDate_ValueChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMale.Location = new System.Drawing.Point(192, 374);
            this.rbMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(71, 23);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "ERKEK";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbFemale.Location = new System.Drawing.Point(345, 374);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(70, 23);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "KADIN";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // lblContains
            // 
            this.lblContains.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblContains.Location = new System.Drawing.Point(58, 142);
            this.lblContains.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContains.Name = "lblContains";
            this.lblContains.Size = new System.Drawing.Size(505, 51);
            this.lblContains.TabIndex = 6;
            this.lblContains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContinueToMain
            // 
            this.btnContinueToMain.FlatAppearance.BorderSize = 0;
            this.btnContinueToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinueToMain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContinueToMain.Image = ((System.Drawing.Image)(resources.GetObject("btnContinueToMain.Image")));
            this.btnContinueToMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinueToMain.Location = new System.Drawing.Point(502, 463);
            this.btnContinueToMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinueToMain.Name = "btnContinueToMain";
            this.btnContinueToMain.Size = new System.Drawing.Size(44, 40);
            this.btnContinueToMain.TabIndex = 8;
            this.btnContinueToMain.UseVisualStyleBackColor = true;
            this.btnContinueToMain.Click += new System.EventHandler(this.btnContinueToMain_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(520, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 41);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.FlatAppearance.BorderSize = 0;
            this.btnBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackward.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackward.Image = ((System.Drawing.Image)(resources.GetObject("btnBackward.Image")));
            this.btnBackward.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackward.Location = new System.Drawing.Point(31, 463);
            this.btnBackward.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(44, 40);
            this.btnBackward.TabIndex = 12;
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 534);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnContinueToMain);
            this.Controls.Add(this.lblContains);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.dtBirthDate);
            this.Controls.Add(this.nmrHeight);
            this.Controls.Add(this.nmrWeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserMail);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrWeight;
        private System.Windows.Forms.NumericUpDown nmrHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lblContains;
        private System.Windows.Forms.Button btnContinueToMain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBackward;
    }
}