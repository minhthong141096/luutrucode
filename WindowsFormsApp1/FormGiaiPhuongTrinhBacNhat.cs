using sudungham;
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
    public partial class FormGiaiPhuongTrinhBacNhat : Form
    {
        public FormGiaiPhuongTrinhBacNhat()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (double.TryParse(txtsothunhat.Text, out a) == false)
                {
                    txtsothunhat.SelectAll();
                    txtsothunhat.Focus();
                    throw new Exception("Du lieu nhap khong hop le");
                }
                if (double.TryParse(txtsothuhai.Text, out b) == false)
                {
                    txtsothuhai.SelectAll();
                    txtsothuhai.Focus();
                    throw new Exception("Du lieu nhap khong hop le");
                }
                if (a == 0)
                {
                    txtsothunhat.SelectAll();
                    txtsothunhat.Focus();
                    throw new Exception("Vo nghia");
                }
                PhuongTrinh pt = new PhuongTrinh();
                txtketqua.Text = pt.PhuongTrinhBac1(a, b).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Loi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }


        private void txtsothunhat_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (double.TryParse(txtsothunhat.Text, out a) == false)
            {
                txtsothunhat.Text = " ";
            }
        }

        private void txtsothuhai_TextChanged(object sender, EventArgs e)
        {
            double b;
            if (double.TryParse(txtsothunhat.Text, out b) == false)
            {
                txtsothuhai.Text = " ";
            }
        }

        private void txttieude_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
           
                this.Close();
            
        }

        private void FormGiaiPhuongTrinhBacNhat_FormClosing(object sender, FormClosingEventArgs e)
        {
            var isOk = MessageBox.Show("Ban co muon thoat khong", "ThongBao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (isOk == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
