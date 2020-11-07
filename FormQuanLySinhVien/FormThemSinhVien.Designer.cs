namespace FormQuanLySinhVien
{
    partial class FormThemSinhVien
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.txttensv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbgioitinh = new System.Windows.Forms.ComboBox();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(12, 52);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(251, 20);
            this.txtmasv.TabIndex = 2;
            // 
            // txttensv
            // 
            this.txttensv.Location = new System.Drawing.Point(12, 116);
            this.txttensv.Name = "txttensv";
            this.txttensv.Size = new System.Drawing.Size(251, 20);
            this.txttensv.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Sinh Viên";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(12, 186);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(251, 20);
            this.txtsdt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Sinh";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(12, 370);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(251, 20);
            this.txtdiachi.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Địa Chỉ";
            // 
            // cbbgioitinh
            // 
            this.cbbgioitinh.FormattingEnabled = true;
            this.cbbgioitinh.Location = new System.Drawing.Point(12, 248);
            this.cbbgioitinh.Name = "cbbgioitinh";
            this.cbbgioitinh.Size = new System.Drawing.Size(251, 21);
            this.cbbgioitinh.TabIndex = 13;
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.Location = new System.Drawing.Point(12, 308);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(254, 20);
            this.dtngaysinh.TabIndex = 14;
            // 
            // FormThemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 464);
            this.Controls.Add(this.dtngaysinh);
            this.Controls.Add(this.cbbgioitinh);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttensv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FormThemSinhVien";
            this.Text = "FormThemSinhVien";
            this.Load += new System.EventHandler(this.FormThemSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.TextBox txttensv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbgioitinh;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
    }
}