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
    public partial class FormPhepNhan : Form
    {
        public FormPhepNhan()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double a, b;
            double.TryParse(txtsothunhat.Text, out a);
            double.TryParse(txtsothuhai.Text, out b);
            PhuongTrinh pt = new PhuongTrinh();
            txtketqua.Text = pt.Tich(a, b).ToString ();

        }
    }
}
