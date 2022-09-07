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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSriDalada SriDalada = new frmSriDalada();
            SriDalada.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PeraBotGa form = new PeraBotGa();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GalleFort form5 = new GalleFort();
            form5.Show();
        }
    }
}
