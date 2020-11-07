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
    public partial class FormThemSinhVien : Form
    {
        public FormThemSinhVien()
        {
            InitializeComponent();
        }

        private void FormThemSinhVien_Load(object sender, EventArgs e)
        {
            List<GioiTinh> lgt = GioiTinh.Get();
            cbbgioitinh.DataSource = lgt;
            cbbgioitinh.DisplayMember = "Name";
            cbbgioitinh.ValueMember = "Id";
            //gán giá trị mặc định
            cbbgioitinh.SelectedIndex = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Sinhvien sv = GetInPutSinhVien();
                Sinhvien.Them(sv);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 

        private Sinhvien GetInPutSinhVien()
        {
            if (txtmasv.Text == "")
            {
                txtmasv.Focus();
                throw new Exception(" Nhập mã sinh viên");
            }
            if (txttensv.Text == "")
            {
                txttensv.Focus();
                throw new Exception(" Nhập tên sinh viên");
            }
            if (txtdiachi.Text == "")
            {
                txtdiachi.Focus();
                throw new Exception(" Nhập địa chỉ ");
            }
            GioiTinh gt = (GioiTinh)
                cbbgioitinh.SelectedItem;
            return new Sinhvien(txtmasv.Text, txttensv.Text, txtdiachi.Text, txtsdt.Text,gt.Id,dtngaysinh.Value);
        }

    }
 }

