namespace WindowsFormsApp1
{
    partial class FormGiaiPhuongTrinhBacNhat
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsothuhai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.txtsothunhat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttieude = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(534, 294);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(415, 148);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(100, 20);
            this.txtketqua.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ket qua";
            // 
            // txtsothuhai
            // 
            this.txtsothuhai.Location = new System.Drawing.Point(240, 148);
            this.txtsothuhai.Name = "txtsothuhai";
            this.txtsothuhai.Size = new System.Drawing.Size(100, 20);
            this.txtsothuhai.TabIndex = 17;
            this.txtsothuhai.TextChanged += new System.EventHandler(this.txtsothuhai_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "So thu hai";
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(255, 224);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 19;
            this.btntinh.Text = "Tinh ";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // txtsothunhat
            // 
            this.txtsothunhat.Location = new System.Drawing.Point(64, 148);
            this.txtsothunhat.Name = "txtsothunhat";
            this.txtsothunhat.Size = new System.Drawing.Size(100, 20);
            this.txtsothunhat.TabIndex = 16;
            this.txtsothunhat.TextChanged += new System.EventHandler(this.txtsothunhat_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "So thu nhat";
            // 
            // txttieude
            // 
            this.txttieude.Location = new System.Drawing.Point(121, 49);
            this.txttieude.Name = "txttieude";
            this.txttieude.Size = new System.Drawing.Size(309, 20);
            this.txttieude.TabIndex = 23;
            this.txttieude.TextChanged += new System.EventHandler(this.txttieude_TextChanged);
            // 
            // FormGiaiPhuongTrinhBacNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 326);
            this.Controls.Add(this.txttieude);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsothuhai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtsothunhat);
            this.Controls.Add(this.label1);
            this.Name = "FormGiaiPhuongTrinhBacNhat";
            this.Text = "FormGiaiPhuongTrinhBacNhat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGiaiPhuongTrinhBacNhat_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsothuhai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.TextBox txtsothunhat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttieude;
    }
}