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
    public partial class FormTimMax : Form
    {
        public FormTimMax()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double a, b, c;
            double.TryParse(txtsothunhat.Text, out a);
            double.TryParse(txtsothuhai.Text, out b);
            double.TryParse(txtsothuba.Text, out c);
            PhuongTrinh pt = new PhuongTrinh();
            txtketqua.Text = pt.Timmax(a, b, c).ToString();
        }
    }
}
