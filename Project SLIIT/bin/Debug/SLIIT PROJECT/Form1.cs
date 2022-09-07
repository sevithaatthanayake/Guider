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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTravel_Click(object sender, EventArgs e)
        {
            Travel Form2 = new Travel();
            Form2.Show();

        }

        private void btnTips_Click(object sender, EventArgs e)
        {
            Other Form3 = new Other();
            Form3.Show();
        }

        private void btnRdRules_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diary diary = new Diary();
            diary.Show();
        }
    }
}
