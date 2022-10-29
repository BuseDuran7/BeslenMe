
namespace BeslanMeSablon
{
    partial class Introduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Introduction));
            this.buttonContinue = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonContinue
            // 
            this.buttonContinue.FlatAppearance.BorderSize = 0;
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonContinue.Image = ((System.Drawing.Image)(resources.GetObject("buttonContinue.Image")));
            this.buttonContinue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonContinue.Location = new System.Drawing.Point(687, 383);
            this.buttonContinue.Margin = new System.Windows.Forms.Padding(4);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(44, 40);
            this.buttonContinue.TabIndex = 8;
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInformation.Location = new System.Drawing.Point(64, 151);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(692, 208);
            this.lblInformation.TabIndex = 9;
            this.lblInformation.Text = "label1";
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.Location = new System.Drawing.Point(713, 13);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(43, 41);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.FlatAppearance.BorderSize = 0;
            this.btnBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackward.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackward.Image = ((System.Drawing.Image)(resources.GetObject("btnBackward.Image")));
            this.btnBackward.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackward.Location = new System.Drawing.Point(42, 383);
            this.btnBackward.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(44, 40);
            this.btnBackward.TabIndex = 11;
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.buttonContinue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Introduction";
            this.Text = "Introduction";
            this.Load += new System.EventHandler(this.Introduction_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button btnBackward;
    }
}