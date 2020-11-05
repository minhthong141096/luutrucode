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
    public partial class FormDanhSachLopHoc : Form
    {
        public FormDanhSachLopHoc()
        {
            InitializeComponent();
        }

        private void FormDanhSachLopHoc_Load(object sender, EventArgs e)
        {
            ResetDanhSach();
        }

        private void ResetDanhSach()
        {
            LopHoc lophoc = new LopHoc();
            if (LopHoc.DanhSachLopHoc != null)
                dgvdanhsachlophoc.DataSource = LopHoc.DanhSachLopHoc.ToList();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Form fthem = new FormThemLopHoc();
            var isOk = fthem.ShowDialog();
            if (isOk == DialogResult.OK)
            {
                ResetDanhSach();
            }
        }

        private void dgvdanhsachlophoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            //Lấy mã lớp học khi chọn
           string malophoc = dgvdanhsachlophoc.Rows[e.RowIndex].Cells[0].Value.ToString();
            //MessageBox.Show(malophoc.ToString());

        }
    }
}
