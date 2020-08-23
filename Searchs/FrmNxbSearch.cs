using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VuBookStorev5
{
    public partial class FrmNxb : Form
    {
        public FrmNxb()
        {
            InitializeComponent();
        }

        private void Ti_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookDBContext bookdb = new BookDBContext();
            var boo = from NxbID in bookdb.Nxbs select NxbID;
            dataGridView1.DataSource = boo.ToList();
        }
    }
}
