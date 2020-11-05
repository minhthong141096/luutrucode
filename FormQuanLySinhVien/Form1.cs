using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormQuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void điểmTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fThemLop = new FormBaoCaoDiemTheoLop();
            fThemLop.MdiParent = this;
            fThemLop.Show();
        }

        private void sinhViênHọcLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form fThemLop = new FormBaoCaoSinhVienHocLai();
            fThemLop.MdiParent = this;
            fThemLop.Show();
        }

        private void sinhViênTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form fThemLop = new FormBaoCaoSinhVienTheoLop();
            fThemLop.MdiParent = this;
            fThemLop.Show();
        }

        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form fThemLop = new FormThemSinhVien();
            fThemLop.MdiParent = this;
            fThemLop.Show();
        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form fThemLop = new FormDanhSachSinhVien();
            fThemLop.MdiParent = this;
            fThemLop.Show();
        }

        private void thêmLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form fThemLop = new FormThemLopHoc();
           // fThemLop.MdiParent = this;
            fThemLop.ShowDialog();
        }

        private void danhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form fThemLop = new FormDanhSachLopHoc();
            fThemLop.MdiParent = this;
            fThemLop.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
