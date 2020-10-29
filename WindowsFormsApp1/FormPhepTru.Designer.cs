namespace WindowsFormsApp1
{
    partial class FormPhepTru
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
            this.txtsothunhat = new System.Windows.Forms.TextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.txtsothuhai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "So thu nhat";
            // 
            // txtsothunhat
            // 
            this.txtsothunhat.Location = new System.Drawing.Point(49, 88);
            this.txtsothunhat.Name = "txtsothunhat";
            this.txtsothunhat.Size = new System.Drawing.Size(100, 20);
            this.txtsothunhat.TabIndex = 1;
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(240, 164);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 3;
            this.btntinh.Text = "Tinh ";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // txtsothuhai
            // 
            this.txtsothuhai.Location = new System.Drawing.Point(225, 88);
            this.txtsothuhai.Name = "txtsothuhai";
            this.txtsothuhai.Size = new System.Drawing.Size(100, 20);
            this.txtsothuhai.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "So thu hai";
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(400, 88);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(100, 20);
            this.txtketqua.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ket qua";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(519, 234);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormPhepTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 269);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsothuhai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtsothunhat);
            this.Controls.Add(this.label1);
            this.Name = "FormPhepTru";
            this.Text = "FormPhepTru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsothunhat;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.TextBox txtsothuhai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
    }
}