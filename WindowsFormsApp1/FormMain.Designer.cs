namespace WindowsFormsApp1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.phepTinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cộngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trừToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giảiPhươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phươngTrìnhBậc1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phươngTrìnhBậc2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmMaxMinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tìmMinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phepTinhToolStripMenuItem,
            this.giảiPhươngTrìnhToolStripMenuItem,
            this.tìmMaxMinToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // phepTinhToolStripMenuItem
            // 
            this.phepTinhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cộngToolStripMenuItem,
            this.trừToolStripMenuItem,
            this.nhânToolStripMenuItem,
            this.chiaToolStripMenuItem});
            this.phepTinhToolStripMenuItem.Name = "phepTinhToolStripMenuItem";
            this.phepTinhToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.phepTinhToolStripMenuItem.Text = "Phép tính";
            // 
            // cộngToolStripMenuItem
            // 
            this.cộngToolStripMenuItem.Name = "cộngToolStripMenuItem";
            this.cộngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cộngToolStripMenuItem.Text = "Cộng";
            this.cộngToolStripMenuItem.Click += new System.EventHandler(this.cộngToolStripMenuItem_Click);
            // 
            // trừToolStripMenuItem
            // 
            this.trừToolStripMenuItem.Name = "trừToolStripMenuItem";
            this.trừToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trừToolStripMenuItem.Text = "Trừ";
            this.trừToolStripMenuItem.Click += new System.EventHandler(this.trừToolStripMenuItem_Click);
            // 
            // nhânToolStripMenuItem
            // 
            this.nhânToolStripMenuItem.Name = "nhânToolStripMenuItem";
            this.nhânToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nhânToolStripMenuItem.Text = "Nhân";
            this.nhânToolStripMenuItem.Click += new System.EventHandler(this.nhânToolStripMenuItem_Click);
            // 
            // chiaToolStripMenuItem
            // 
            this.chiaToolStripMenuItem.Name = "chiaToolStripMenuItem";
            this.chiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chiaToolStripMenuItem.Text = "Chia";
            this.chiaToolStripMenuItem.Click += new System.EventHandler(this.chiaToolStripMenuItem_Click);
            // 
            // giảiPhươngTrìnhToolStripMenuItem
            // 
            this.giảiPhươngTrìnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phươngTrìnhBậc1ToolStripMenuItem,
            this.phươngTrìnhBậc2ToolStripMenuItem});
            this.giảiPhươngTrìnhToolStripMenuItem.Name = "giảiPhươngTrìnhToolStripMenuItem";
            this.giảiPhươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.giảiPhươngTrìnhToolStripMenuItem.Text = "Giải Phương Trình";
            // 
            // phươngTrìnhBậc1ToolStripMenuItem
            // 
            this.phươngTrìnhBậc1ToolStripMenuItem.Name = "phươngTrìnhBậc1ToolStripMenuItem";
            this.phươngTrìnhBậc1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phươngTrìnhBậc1ToolStripMenuItem.Text = "Phương Trình bậc 1";
            this.phươngTrìnhBậc1ToolStripMenuItem.Click += new System.EventHandler(this.phươngTrìnhBậc1ToolStripMenuItem_Click);
            // 
            // phươngTrìnhBậc2ToolStripMenuItem
            // 
            this.phươngTrìnhBậc2ToolStripMenuItem.Name = "phươngTrìnhBậc2ToolStripMenuItem";
            this.phươngTrìnhBậc2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phươngTrìnhBậc2ToolStripMenuItem.Text = "Phương Trình Bậc 2";
            this.phươngTrìnhBậc2ToolStripMenuItem.Click += new System.EventHandler(this.phươngTrìnhBậc2ToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // tìmMaxMinToolStripMenuItem
            // 
            this.tìmMaxMinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmMaxToolStripMenuItem,
            this.tìmMinToolStripMenuItem});
            this.tìmMaxMinToolStripMenuItem.Name = "tìmMaxMinToolStripMenuItem";
            this.tìmMaxMinToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.tìmMaxMinToolStripMenuItem.Text = "Tìm Max, min";
            // 
            // tìmMaxToolStripMenuItem
            // 
            this.tìmMaxToolStripMenuItem.Name = "tìmMaxToolStripMenuItem";
            this.tìmMaxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tìmMaxToolStripMenuItem.Text = "Tìm max";
            this.tìmMaxToolStripMenuItem.Click += new System.EventHandler(this.tìmMaxToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tìmMinToolStripMenuItem
            // 
            this.tìmMinToolStripMenuItem.Name = "tìmMinToolStripMenuItem";
            this.tìmMinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tìmMinToolStripMenuItem.Text = "Tìm min";
            this.tìmMinToolStripMenuItem.Click += new System.EventHandler(this.tìmMinToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 264);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem phepTinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cộngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trừToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giảiPhươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phươngTrìnhBậc1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phươngTrìnhBậc2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmMaxMinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmMaxToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tìmMinToolStripMenuItem;
    }
}