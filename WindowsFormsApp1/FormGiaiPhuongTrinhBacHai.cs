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
    public partial class FormGiaiPhuongTrinhBacHai : Form
    {
        public FormGiaiPhuongTrinhBacHai()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c;
                if(double.TryParse(txtsothunhat.Text, out a)==false)
                {
                    txtsothunhat.SelectAll();
                    txtsothunhat.Focus();
                    throw new Exception("Du lieu khong hop le");
                }
                if (double.TryParse(txtsothuhai.Text, out b) == false)
                {
                    txtsothuhai.SelectAll();
                    txtsothuhai.Focus();
                    throw new Exception("Du lieu khong hop le");
                }
                if (double.TryParse(txtsothuba.Text, out c) == false)
                {
                    txtsothuba.SelectAll();
                    txtsothuba.Focus();
                    throw new Exception("Du lieu khong hop le");
                }
                PhuongTrinh  pt = new PhuongTrinh();
                double [] nghiem = pt.PhuongTrinhBacHai(a,b,c);
                // txtketqua1.Text =  pt.PhuongTrinhBacHai(a, b, c)[0].ToString();
                //txtketqua.Text =  pt.PhuongTrinhBacHai(a, b, c)[1].ToString();
                txtketqua.Text = nghiem[0].ToString();
                txtketqua1.Text = nghiem[1].ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void txtketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
