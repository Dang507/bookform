using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VuBookStorev5.Models;

namespace VuBookStorev5.Nhap
{
    public partial class FrmBookTitle : Form
    {
        BookTitle bookTitle = new BookTitle();
        public FrmBookTitle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookDBContext bookdb = new BookDBContext();
            var boo = from BT_ID in bookdb.BookTitles select BT_ID;
            dataGridView1.DataSource = boo.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookTitle.BT_ID = textBox3.Text;
            bookTitle.BT_Name = textBox6.Text;
            try
            {
                BookDBContext bookdb = new BookDBContext();
                BookTitle book = new BookTitle();
              
                bookdb.BookTitles.Add(bookTitle);
               
                bookdb.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }

        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void nhậpSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmBookDetail = new FrmBookDetail();
            frmBookDetail.Show();
        }

        private void nhậpThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
