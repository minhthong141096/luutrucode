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
        public int IsThis = 1;
        //1 
        public FormCapNhatBangDiem()
        {
            InitializeComponent();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                BangDiem bd = GetInputForm();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private BangDiem GetInputForm()
        {
            if(txtdiemtoan.Text=="")
            {
                txtdiemtoan.SelectAll();
                txtdiemtoan.Focus();
                throw new Exception("Bạn Chưa Nhập điểm Toán");
            }
            if (txtdiemhoa.Text == "")
            {
                txtdiemhoa.SelectAll();
                txtdiemhoa.Focus();
                throw new Exception("Bạn Chưa Nhập điểm Hóa");
            }
            if (txtdiemly.Text == "")
            {
                txtdiemly.SelectAll();
                txtdiemly.Focus();
                throw new Exception("Bạn Chưa Nhập điểm Lý");
            }
            double toan, ly, hoa;
            #region diemtoan
            if (double.TryParse(txtdiemtoan.Text, out toan) == true)
            {
                if(toan >10 || toan <0)
                {
                    txtdiemtoan.SelectAll();
                    txtdiemtoan.Focus();
                    throw new Exception("Điểm không hợp lệ");
                }
            }
            else
            {
                txtdiemtoan.SelectAll();
                txtdiemtoan.Focus();
                throw new Exception("Điểm không hợp lệ");
            }
            #endregion
            #region diemhoa
            if (double.TryParse(txtdiemhoa.Text, out hoa) == true)
            {
                if (hoa > 10 || hoa < 0)
                {
                    txtdiemhoa.SelectAll();
                    txtdiemhoa.Focus();
                    throw new Exception("Điểm không hợp lệ");
                }
            }
            else
            {
                txtdiemhoa.SelectAll();
                txtdiemhoa.Focus();
                throw new Exception("Điểm không hợp lệ");
            }
            #endregion
            #region diemly
            if (double.TryParse(txtdiemly.Text, out ly) == true)
            {
                if (ly > 10 || ly < 0)
                {
                    txtdiemly.SelectAll();
                    txtdiemly.Focus();
                    throw new Exception("Điểm không hợp lệ");
                }
            }
            else
            {
                txtdiemly.SelectAll();
                txtdiemly.Focus();
                throw new Exception("Điểm không hợp lệ");
            }
            #endregion
            Sinhvien iteamSV = (Sinhvien)cbbmasinhvien.SelectedItem;
            LopHoc iteamLH = (LopHoc)cbbmalop.SelectedItem;
            return new BangDiem(iteamSV.MaSV, iteamLH.MaLop,toan, ly , hoa);
        }

        private void FormCapNhatBangDiem_Load(object sender, EventArgs e)
        {
            cbbmalop.DataSource = LopHoc.GetDanhSachLopHoc();
            cbbmalop.DisplayMember = "TenLop";
            cbbmalop.ValueMember = "MaLop";
            cbbmasinhvien.DataSource = Sinhvien.GetDanhSachSinhVien().ToList();
            cbbmasinhvien.DisplayMember = "TenSinhVien";
            cbbmasinhvien.ValueMember = "MaSV";

        }
      
       
    }
}
