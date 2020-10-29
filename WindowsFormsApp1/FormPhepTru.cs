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
    public partial class FormPhepTru : Form
    {
        public FormPhepTru()
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
                    throw new Exception("Du lieu khong hop le");
                }

                if (double.TryParse(txtsothuhai.Text, out b) == false) 
                {
                    txtsothuhai.SelectAll();
                    txtsothuhai.Focus();
                    throw new Exception("Du lieu khong hop le");
                }

                PhuongTrinh pt = new PhuongTrinh();
                txtketqua.Text = pt.Hieu(a, b).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Loi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
