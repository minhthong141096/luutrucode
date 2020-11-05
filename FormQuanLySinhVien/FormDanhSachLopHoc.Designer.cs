namespace FormQuanLySinhVien
{
    partial class FormDanhSachLopHoc
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
            this.dgvdanhsachlophoc = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachlophoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdanhsachlophoc
            // 
            this.dgvdanhsachlophoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdanhsachlophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsachlophoc.Location = new System.Drawing.Point(0, 160);
            this.dgvdanhsachlophoc.Name = "dgvdanhsachlophoc";
            this.dgvdanhsachlophoc.Size = new System.Drawing.Size(597, 235);
            this.dgvdanhsachlophoc.TabIndex = 1;
            this.dgvdanhsachlophoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsachlophoc_CellContentClick);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(24, 119);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // FormDanhSachLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 395);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvdanhsachlophoc);
            this.Name = "FormDanhSachLopHoc";
            this.Text = "FormDanhSachLopHoc";
            this.Load += new System.EventHandler(this.FormDanhSachLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachlophoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdanhsachlophoc;
        private System.Windows.Forms.Button btnthem;
    }
}