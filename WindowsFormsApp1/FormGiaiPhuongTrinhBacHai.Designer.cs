namespace WindowsFormsApp1
{
    partial class FormGiaiPhuongTrinhBacHai
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
            this.txtketqua1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsothuhai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.txtsothunhat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsothuba = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(624, 316);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtketqua1
            // 
            this.txtketqua1.Location = new System.Drawing.Point(568, 151);
            this.txtketqua1.Name = "txtketqua1";
            this.txtketqua1.Size = new System.Drawing.Size(134, 20);
            this.txtketqua1.TabIndex = 28;
            this.txtketqua1.TextChanged += new System.EventHandler(this.txtketqua_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ket qua";
            // 
            // txtsothuhai
            // 
            this.txtsothuhai.Location = new System.Drawing.Point(179, 151);
            this.txtsothuhai.Name = "txtsothuhai";
            this.txtsothuhai.Size = new System.Drawing.Size(100, 20);
            this.txtsothuhai.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "So thu hai";
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(322, 240);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 27;
            this.btntinh.Text = "Tinh ";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // txtsothunhat
            // 
            this.txtsothunhat.Location = new System.Drawing.Point(26, 151);
            this.txtsothunhat.Name = "txtsothunhat";
            this.txtsothunhat.Size = new System.Drawing.Size(100, 20);
            this.txtsothunhat.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "So thu nhat";
            // 
            // txtsothuba
            // 
            this.txtsothuba.Location = new System.Drawing.Point(329, 151);
            this.txtsothuba.Name = "txtsothuba";
            this.txtsothuba.Size = new System.Drawing.Size(100, 20);
            this.txtsothuba.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "So thu ba";
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(568, 200);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(134, 20);
            this.txtketqua.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "X1=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "X2=";
            // 
            // FormGiaiPhuongTrinhBacHai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 351);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtsothuba);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtketqua1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsothuhai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtsothunhat);
            this.Controls.Add(this.label1);
            this.Name = "FormGiaiPhuongTrinhBacHai";
            this.Text = "FormGiaiPhuongTrinhBacHai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtketqua1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsothuhai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.TextBox txtsothunhat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsothuba;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}