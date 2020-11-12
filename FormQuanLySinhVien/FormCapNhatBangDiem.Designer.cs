namespace FormQuanLySinhVien
{
    partial class FormCapNhatBangDiem
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
            this.dgvbangdiem = new System.Windows.Forms.DataGridView();
            this.cbbmalop = new System.Windows.Forms.ComboBox();
            this.cbbmasinhvien = new System.Windows.Forms.ComboBox();
            this.txtdiemtoan = new System.Windows.Forms.TextBox();
            this.txtdiemly = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiemhoa = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbangdiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbangdiem
            // 
            this.dgvbangdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbangdiem.Location = new System.Drawing.Point(-1, -1);
            this.dgvbangdiem.Name = "dgvbangdiem";
            this.dgvbangdiem.Size = new System.Drawing.Size(480, 452);
            this.dgvbangdiem.TabIndex = 0;
            // 
            // cbbmalop
            // 
            this.cbbmalop.FormattingEnabled = true;
            this.cbbmalop.Location = new System.Drawing.Point(503, 39);
            this.cbbmalop.Name = "cbbmalop";
            this.cbbmalop.Size = new System.Drawing.Size(121, 21);
            this.cbbmalop.TabIndex = 1;
            // 
            // cbbmasinhvien
            // 
            this.cbbmasinhvien.FormattingEnabled = true;
            this.cbbmasinhvien.Location = new System.Drawing.Point(503, 94);
            this.cbbmasinhvien.Name = "cbbmasinhvien";
            this.cbbmasinhvien.Size = new System.Drawing.Size(121, 21);
            this.cbbmasinhvien.TabIndex = 2;
            // 
            // txtdiemtoan
            // 
            this.txtdiemtoan.Location = new System.Drawing.Point(503, 168);
            this.txtdiemtoan.Name = "txtdiemtoan";
            this.txtdiemtoan.Size = new System.Drawing.Size(121, 20);
            this.txtdiemtoan.TabIndex = 3;
            // 
            // txtdiemly
            // 
            this.txtdiemly.Location = new System.Drawing.Point(503, 234);
            this.txtdiemly.Name = "txtdiemly";
            this.txtdiemly.Size = new System.Drawing.Size(121, 20);
            this.txtdiemly.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã SInh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Điểm Toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Điểm Lý";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Điểm Hóa";
            // 
            // txtdiemhoa
            // 
            this.txtdiemhoa.Location = new System.Drawing.Point(503, 301);
            this.txtdiemhoa.Name = "txtdiemhoa";
            this.txtdiemhoa.Size = new System.Drawing.Size(121, 20);
            this.txtdiemhoa.TabIndex = 9;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(500, 363);
            this.btnluu.Name = "btnluu";
            this.btnluu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 11;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(609, 363);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 12;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // FormCapNhatBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdiemhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdiemly);
            this.Controls.Add(this.txtdiemtoan);
            this.Controls.Add(this.cbbmasinhvien);
            this.Controls.Add(this.cbbmalop);
            this.Controls.Add(this.dgvbangdiem);
            this.Name = "FormCapNhatBangDiem";
            this.Text = "FormCapNhatBangDiem";
            this.Load += new System.EventHandler(this.FormCapNhatBangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbangdiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbangdiem;
        private System.Windows.Forms.ComboBox cbbmalop;
        private System.Windows.Forms.ComboBox cbbmasinhvien;
        private System.Windows.Forms.TextBox txtdiemtoan;
        private System.Windows.Forms.TextBox txtdiemly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdiemhoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
    }
}