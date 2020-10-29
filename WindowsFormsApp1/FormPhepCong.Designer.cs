namespace WindowsFormsApp1
{
    partial class FormPhepCong
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
            this.txtsothunhat = new System.Windows.Forms.TextBox();
            this.lbsothunhat = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.txtsothuhai = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.lbsothuhai = new System.Windows.Forms.Label();
            this.lbketqua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsothunhat
            // 
            this.txtsothunhat.Location = new System.Drawing.Point(40, 101);
            this.txtsothunhat.Name = "txtsothunhat";
            this.txtsothunhat.Size = new System.Drawing.Size(100, 20);
            this.txtsothunhat.TabIndex = 1;
            // 
            // lbsothunhat
            // 
            this.lbsothunhat.AutoSize = true;
            this.lbsothunhat.Location = new System.Drawing.Point(67, 74);
            this.lbsothunhat.Name = "lbsothunhat";
            this.lbsothunhat.Size = new System.Drawing.Size(62, 13);
            this.lbsothunhat.TabIndex = 1;
            this.lbsothunhat.Text = "So thu nhat";
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(182, 170);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(128, 25);
            this.btntinh.TabIndex = 3;
            this.btntinh.Text = "Tinh";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // txtsothuhai
            // 
            this.txtsothuhai.Location = new System.Drawing.Point(196, 101);
            this.txtsothuhai.Name = "txtsothuhai";
            this.txtsothuhai.Size = new System.Drawing.Size(100, 20);
            this.txtsothuhai.TabIndex = 2;
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(354, 101);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(100, 20);
            this.txtketqua.TabIndex = 4;
            // 
            // lbsothuhai
            // 
            this.lbsothuhai.AutoSize = true;
            this.lbsothuhai.Location = new System.Drawing.Point(224, 74);
            this.lbsothuhai.Name = "lbsothuhai";
            this.lbsothuhai.Size = new System.Drawing.Size(55, 13);
            this.lbsothuhai.TabIndex = 5;
            this.lbsothuhai.Text = "So thu hai";
            // 
            // lbketqua
            // 
            this.lbketqua.AutoSize = true;
            this.lbketqua.Location = new System.Drawing.Point(382, 74);
            this.lbketqua.Name = "lbketqua";
            this.lbketqua.Size = new System.Drawing.Size(46, 13);
            this.lbketqua.TabIndex = 6;
            this.lbketqua.Text = "Ket Qua";
            // 
            // FormPhepCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 218);
            this.Controls.Add(this.lbketqua);
            this.Controls.Add(this.lbsothuhai);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtsothuhai);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.lbsothunhat);
            this.Controls.Add(this.txtsothunhat);
            this.Name = "FormPhepCong";
            this.Text = "FormPhepCong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsothunhat;
        private System.Windows.Forms.Label lbsothunhat;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.TextBox txtsothuhai;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label lbsothuhai;
        private System.Windows.Forms.Label lbketqua;
    }
}