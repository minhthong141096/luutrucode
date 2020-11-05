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
    public partial class FormThemLopHoc : Form
    {
        public FormThemLopHoc()
        {
            InitializeComponent();
        }
        /// <summary>
        /// thêm lớp học
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnthem_Click(object sender, EventArgs e)
        {
            
            try
            {
                LopHoc lh = GetInputForm();
                lh.Them();
                //MessageBox.Show(lh.LopHoc2String());
                //Form formDanhSach = new FormDanhSachLopHoc();
                //formDanhSach.Show();
                DialogResult = DialogResult.OK;
                //Close();
                //SetInputForm(new LopHoc());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// gán thông tin cho form
        /// </summary>
        /// <param name="lopHoc"></param>
        private void SetInputForm(LopHoc lopHoc)
        {
            txtmalop.Text = lopHoc.MaLop;
            txtdiachi.Text = lopHoc.DiaChi;
            txttenlop.Text = lopHoc.TenLop;
        }
        //lấy thông tin cho form
        private LopHoc GetInputForm()
        {
            if(txtmalop.Text== "")
            {
                throw new Exception("Vui lòng nhập mã lớp");
            }
            if (txttenlop.Text == "")
            {
                throw new Exception("Vui lòng nhập tên lớp");
            }
            if (txtdiachi.Text == "")
            {
                throw new Exception("Vui lòng nhập địa chỉ");
            }
            return new LopHoc(txtmalop.Text, txttenlop.Text, txtdiachi.Text);
        }
    }
}
