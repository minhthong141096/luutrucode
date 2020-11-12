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
    public partial class FormCapNhatBangDiem : Form
    {
        public FormCapNhatBangDiem()
        {
            InitializeComponent();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            Form fluu = new FormThemDiem();
            var isOk = fluu.ShowDialog();
            if(isOk==DialogResult.OK)
            {
                ResetDanhSachBangDiem();
            }    
        }

        private void FormCapNhatBangDiem_Load(object sender, EventArgs e)
        {
            ResetDanhSachBangDiem();
        }

        private void ResetDanhSachBangDiem()
        {
            BangDiem bangdiem = new BangDiem();
            if (BangDiem.DanhSachBangDiem != null)
                dgvbangdiem.DataSource = BangDiem.DanhSachBangDiem.ToList();
        }
    }
}
