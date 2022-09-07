using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_SLIIT
{
    public partial class GalleFort : Form
    {
        public GalleFort()
        {
            InitializeComponent();
        }

        private void GalleFort_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
