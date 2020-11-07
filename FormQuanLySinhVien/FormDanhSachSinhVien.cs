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
    public partial class FormDanhSachSinhVien : Form
    {
        public FormDanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void FormDanhSachSinhVien_Load(object sender, EventArgs e)
        {
            resetDanhSachSinhVien();
        }

        private void resetDanhSachSinhVien()
        {
            Sinhvien sv = new Sinhvien();
            if (Sinhvien.DanhSachSinhVien != null)
                dgvdanhsachsinhvien.DataSource = Sinhvien.DanhSachSinhVien.ToList();   
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Form fthemsv = new FormThemSinhVien();
            var isOk = fthemsv.ShowDialog();
            if(isOk==DialogResult.OK)
            {
                resetDanhSachSinhVien();
            }    
        }
    }
}
