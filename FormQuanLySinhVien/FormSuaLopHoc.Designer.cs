namespace FormQuanLySinhVien
{
    partial class FormSuaLopHoc
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
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnxoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttenlop
            // 
            this.txttenlop.Location = new System.Drawing.Point(27, 186);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(238, 20);
            this.txttenlop.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Địa Chỉ";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(27, 262);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(238, 20);
            this.txtdiachi.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Lớp";
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(30, 342);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(98, 23);
            this.btnsua.TabIndex = 11;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // txtmalop
            // 
            this.txtmalop.Location = new System.Drawing.Point(27, 115);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.ReadOnly = true;
            this.txtmalop.Size = new System.Drawing.Size(238, 20);
            this.txtmalop.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Lớp";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(158, 342);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(98, 23);
            this.btnxoa.TabIndex = 35;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // FormSuaLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 420);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.txttenlop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.txtmalop);
            this.Controls.Add(this.label1);
            this.Name = "FormSuaLopHoc";
            this.Text = "FormSuaLopHoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnxoa;
    }
}