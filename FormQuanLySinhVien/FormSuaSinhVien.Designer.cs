namespace FormQuanLySinhVien
{
    partial class FormSuaSinhVien
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
            this.dtbngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbbgioitinh = new System.Windows.Forms.ComboBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsodienthoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttensinhvien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmasinhvien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtbngaysinh
            // 
            this.dtbngaysinh.Location = new System.Drawing.Point(25, 301);
            this.dtbngaysinh.Name = "dtbngaysinh";
            this.dtbngaysinh.Size = new System.Drawing.Size(254, 20);
            this.dtbngaysinh.TabIndex = 33;
            // 
            // cbbgioitinh
            // 
            this.cbbgioitinh.FormattingEnabled = true;
            this.cbbgioitinh.Location = new System.Drawing.Point(25, 241);
            this.cbbgioitinh.Name = "cbbgioitinh";
            this.cbbgioitinh.Size = new System.Drawing.Size(251, 21);
            this.cbbgioitinh.TabIndex = 32;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(25, 363);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(251, 20);
            this.txtdiachi.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Giới Tính";
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.Location = new System.Drawing.Point(25, 179);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.Size = new System.Drawing.Size(251, 20);
            this.txtsodienthoai.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Số Điện Thoại";
            // 
            // txttensinhvien
            // 
            this.txttensinhvien.Location = new System.Drawing.Point(25, 109);
            this.txttensinhvien.Name = "txttensinhvien";
            this.txttensinhvien.Size = new System.Drawing.Size(251, 20);
            this.txttensinhvien.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên Sinh Viên";
            // 
            // txtmasinhvien
            // 
            this.txtmasinhvien.Location = new System.Drawing.Point(25, 45);
            this.txtmasinhvien.Name = "txtmasinhvien";
            this.txtmasinhvien.ReadOnly = true;
            this.txtmasinhvien.Size = new System.Drawing.Size(251, 20);
            this.txtmasinhvien.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(20, 407);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 22;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(111, 407);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 34;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Địa Chỉ";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(204, 407);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 36;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // FormSuaSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.dtbngaysinh);
            this.Controls.Add(this.cbbgioitinh);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsodienthoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttensinhvien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmasinhvien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsua);
            this.Name = "FormSuaSinhVien";
            this.Text = "FormSuaSinhVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSuaSinhVien_FormClosing);
            this.Load += new System.EventHandler(this.FormSuaSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtbngaysinh;
        private System.Windows.Forms.ComboBox cbbgioitinh;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsodienthoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttensinhvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmasinhvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnthoat;
    }
}