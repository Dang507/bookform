using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VuBookStorev5.Models;

namespace VuBookStorev5
{
    public partial class FrmBookDetail : Form
    {
        BookDetail bookdt = new BookDetail();
        public FrmBookDetail()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            bookdt.BookID = textBox1.Text.Trim();
            bookdt.BookName = textBox2.Text.Trim();
            bookdt.AuthorID = textBox4.Text.Trim ();
            //bookdt.UserID = textBox5.Text.Trim();
            bookdt.BT_ID = textBox3.Text.Trim();
            bookdt.NxbID = textBox6.Text.Trim();
           
           BookDBContext bookdb = new BookDBContext ();
            {
                bookdb.BookDeatails.Add(bookdt);
                bookdb.SaveChanges();
            
            }
            MessageBox.Show("Lưu thành công");            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_hienthisach_Click(object sender, EventArgs e)
        {
            BookDBContext bookDB = new BookDBContext();
            var boo = from BookName in bookDB.BookDeatails
                      select BookName;                  
            dataGridView1.DataSource = boo.ToList();

        }

        private void NhapBookTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhapAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhapNxbToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sachToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
