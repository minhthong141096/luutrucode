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
    public partial class FormSuaSinhVien : Form
    {
        private object sv;

        public FormSuaSinhVien()
        {
            InitializeComponent();
            List<GioiTinh> lgt = GioiTinh.Get();
            cbbgioitinh.DataSource = lgt;
            cbbgioitinh.DisplayMember = "Name";
            cbbgioitinh.ValueMember = "Id";
            //khởi tạo các đối tượng form
            
            SetInputForm(Sinhvien.GetSinhVienSua());
        }

        private void SetInputForm(Sinhvien sv)
        {
            txtmasinhvien.Text = sv.MaSV;
            txttensinhvien.Text = sv.TenSV;
            txtdiachi.Text = sv.DiaChi;
            txtsodienthoai.Text = sv.SDT;
            dtbngaysinh.Value = sv.NgaySinh;
            cbbgioitinh.SelectedValue = sv.GioiTinh;
            GioiTinh gt = (GioiTinh)
                cbbgioitinh.SelectedItem;
        }




        private void FormSuaSinhVien_Load(object sender, EventArgs e)
        {
            List<GioiTinh> lgt = GioiTinh.Get();
            cbbgioitinh.DataSource = lgt;
            cbbgioitinh.DisplayMember = "Name";
            cbbgioitinh.ValueMember = "Id";
            cbbgioitinh.SelectedIndex = 0;
        }

        private void FormSuaSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            var isOk = MessageBox.Show("Ban co muon thoat khong", "ThongBao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (isOk == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var isXoa = MessageBox.Show("Ban co muon xoa khong", "ThongBao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (isXoa == DialogResult.Cancel)
                return;
            Sinhvien.Xoa(Sinhvien.GetSinhVienSua().MaSV);
            DialogResult = DialogResult.OK;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                
                Sinhvien svSua = GetInputForm();
                Sinhvien.Sua(svSua);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private Sinhvien GetInputForm()
        {
            
            if (txttensinhvien.Text == "")
            {
                txttensinhvien.Focus();
                throw new Exception(" Nhập tên sinh viên");
            }
            if (txtdiachi.Text == "")
            {
                txtdiachi.Focus();
                throw new Exception(" Nhập địa chỉ ");
            }
            GioiTinh gt = (GioiTinh)
                cbbgioitinh.SelectedItem;

            return new Sinhvien(txtmasinhvien.Text, txttensinhvien.Text, txtdiachi.Text, txtsodienthoai.Text, gt.Id, dtbngaysinh.Value);
        }
    }
}
