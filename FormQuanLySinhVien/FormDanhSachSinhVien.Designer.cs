namespace FormQuanLySinhVien
{
    partial class FormDanhSachSinhVien
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
            this.dgvdanhsachsinhvien = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachsinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdanhsachsinhvien
            // 
            this.dgvdanhsachsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsachsinhvien.Location = new System.Drawing.Point(-2, 166);
            this.dgvdanhsachsinhvien.Name = "dgvdanhsachsinhvien";
            this.dgvdanhsachsinhvien.Size = new System.Drawing.Size(648, 289);
            this.dgvdanhsachsinhvien.TabIndex = 0;
            this.dgvdanhsachsinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsachsinhvien_CellContentClick);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(246, 116);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // FormDanhSachSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvdanhsachsinhvien);
            this.Name = "FormDanhSachSinhVien";
            this.Text = "FormDanhSachSinhVien";
            this.Load += new System.EventHandler(this.FormDanhSachSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachsinhvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdanhsachsinhvien;
        private System.Windows.Forms.Button btnthem;
    }
}