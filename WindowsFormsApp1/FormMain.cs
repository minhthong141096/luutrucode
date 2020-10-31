using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnnuttru_Click(object sender, EventArgs e)
        {
            Form PT = new FormPhepTru();
            PT.Show();
        }

        private void btnnutcong_Click(object sender, EventArgs e)
        {
            FormPhepCong formPhepCong = new FormPhepCong();
            formPhepCong.Show();
        }

        private void btnphepnhan_Click(object sender, EventArgs e)
        {
            FormPhepNhan formPhepNhan = new FormPhepNhan();
            formPhepNhan.Show();

        }

        private void btnphepchia_Click(object sender, EventArgs e)
        {
            FormPhepChia formPhepChia = new FormPhepChia();
            formPhepChia.Show();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var isOk = MessageBox.Show("Ban co muon thoat khong", "Thong bao", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (isOk == DialogResult.No)
            {
                e.Cancel = true;
            }
            if (isOk == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }


        private void cộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PC = new FormPhepCong();
            PC.Show();
        }

        private void trừToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PT = new FormPhepTru();
            PT.Show();
        }

        private void nhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhepNhan formPhepNhan = new FormPhepNhan();
            formPhepNhan.Show();
        }

        private void chiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhepChia formPhepChia = new FormPhepChia();
            formPhepChia.Show();

        }

        private void phươngTrìnhBậc1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiaiPhuongTrinhBacNhat formGiaiPhuongTrinhBacNhat = new FormGiaiPhuongTrinhBacNhat();
            formGiaiPhuongTrinhBacNhat.Show();
        }

        private void phươngTrìnhBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PTB2 = new FormGiaiPhuongTrinhBacHai();
            PTB2.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void tìmMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form TimM = new FormTimMax();
            TimM.Show();
        }

        private void tìmMinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Timm = new FormTimmin();
            Timm.Show();
        }
    }
}
