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
    public partial class FormSuaLopHoc : Form
    {
        public FormSuaLopHoc()
        {
            InitializeComponent();
            SetInputForm(LopHoc.GetThongTinSuaLopHoc());
        }

        private void SetInputForm(LopHoc lopHoc)
        {
            txtmalop.Text = lopHoc.MaLop;
            txttenlop.Text = lopHoc.TenLop;
            txtdiachi.Text = lopHoc.DiaChi;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                LopHoc lhSua = GetInputForm();
                LopHoc.Sua(lhSua);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private LopHoc GetInputForm()
        {
           if(txtmalop.Text=="")
            {
                throw new Exception("Nhập vào mã lớp");
            }
            if (txttenlop.Text == "")
            {
                throw new Exception("Nhập vào tên lớp");
            }
            if (txtdiachi.Text == "")
            {
                throw new Exception("Nhập vào địa chỉ");
            }
            return new LopHoc(txtmalop.Text, txttenlop.Text, txtdiachi.Text);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var isOk = MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (isOk != DialogResult.OK)
                return;
            LopHoc.Xoa(LopHoc.GetThongTinSuaLopHoc().MaLop);
            DialogResult = DialogResult.OK;
        }
    }
}
