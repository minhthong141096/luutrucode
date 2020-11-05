using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                if(txttaikhoan.Text==" ")
                {
                    throw new Exception("Tên Đăng nhập không hợp lệ");
                }
                if(txtmatkhau.Text=="")
                {
                    throw new Exception("Mật khẩu không hợp lệ");
                }
                if (txttaikhoan.Text == "admin" && txtmatkhau.Text == "123456")
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                    throw new Exception("Sai tên đăng nhập");
            }
            catch (Exception ex)
            {

                lblthongbao.Text = ex.Message;
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
