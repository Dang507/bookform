using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VuBookStorev5.Nhap;

namespace VuBookStorev5
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

     

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmNhap = new FrmBookDetail();
            frmNhap.Show();
        }

        private void sáchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frmBookDetail = new FrmBookDetail();
            frmBookDetail.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ngườiDùngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frmNgdung = new FrmUsers();
            frmNgdung.Show();
        }

        private void tìmKiếmTheoNhàXuấtBảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frmNxb = new FrmNxb();
            frmNxb.Show();
        }

        private void tìmKiếmTheoTácGiảToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frmAuthorsearch = new FrmtAuthorSearch();
            frmAuthorsearch.Show();
        }

        private void NxbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmbk = new FrmNhapNxb();
            frmbk.Show();
        }

        private void NhapAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void nhapBookTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
