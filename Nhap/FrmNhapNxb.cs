using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VuBookStorev5.Models;

namespace VuBookStorev5.Nhap
{
    public partial class FrmNhapNxb : Form
    {
        public FrmNhapNxb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookDBContext bookdb = new BookDBContext();
            Nxb nxb = new Nxb();
            nxb.NxbID = textBox3.Text;
            nxb.NxbName = textBox6.Text;
            bookdb.Nxbs.Add(nxb);
            bookdb.SaveChanges();
            MessageBox.Show("Lưu thành công");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookDBContext bookdb = new BookDBContext();
            var boo = from NxbID in bookdb.Nxbs select NxbID;
            dataGridView1.DataSource = boo.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void nhậpSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmBookDetail = new FrmBookDetail();
            frmBookDetail.Show();
        }
    }
}
