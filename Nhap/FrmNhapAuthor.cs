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
    public partial class FrmNhapAuthor : Form
    {
        Author author = new Author();
        public FrmNhapAuthor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookDBContext bookDB = new BookDBContext();
            
            var boo = from AuthorID in bookDB.Authors select AuthorID;
            dataGridView1.DataSource = boo.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            author.AuthorID = textBox3.Text;
            author.AuthorName = textBox6.Text;
            BookDBContext bookdb = new BookDBContext();
            bookdb.Authors.Add(author);
            bookdb.SaveChanges();
        }
    }
}
