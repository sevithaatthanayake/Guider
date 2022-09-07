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
    public partial class PeraBotGa : Form
    {
        public PeraBotGa()
        {
            InitializeComponent();
        }







        private void cboDist_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboDist.SelectedIndex == 0)
            {MessageBox.Show("111.8 Km  / 2 h 54 min ");}
                if (cboDist.SelectedIndex == 1) 
                { MessageBox.Show("130.9 Km /3 h 12 min"); }
                if (cboDist.SelectedIndex == 2)
                { MessageBox.Show("133.7 Km /3 h 8 min"); }
                if (cboDist.SelectedIndex == 3)
                { MessageBox.Show(" 121.5 km/ 2 h 56 min"); }
                if (cboDist.SelectedIndex == 4)
                { MessageBox.Show("98.7 km /2 h 28 min "); }
                if (cboDist.SelectedIndex == 5)
                { MessageBox.Show("5.5 km/ 11 min"); }
                if (cboDist.SelectedIndex == 6)
                { MessageBox.Show("222.1 km/4 h 50 min "); }
                if (cboDist.SelectedIndex == 7)
                { MessageBox.Show(" 183.1 km/3 h 43 min "); }
                if (cboDist.SelectedIndex == 8)
                { MessageBox.Show("116.9 Km /3 h 4min"); }
                if (cboDist.SelectedIndex == 9)
                { MessageBox.Show("183.7Km /3 h 40min"); }
                if (cboDist.SelectedIndex == 10)
                { MessageBox.Show(" 230.5 km/ 4 h 49 Kmmin"); }
                if (cboDist.SelectedIndex == 11)
                { MessageBox.Show("331.7 km / 6 h 8 min"); }
                if (cboDist.SelectedIndex == 12)
                { MessageBox.Show("99.3 Km / 2 h 30min"); }
                if (cboDist.SelectedIndex == 13)
                { MessageBox.Show("78.2Km / 1 h 59min"); }
                if (cboDist.SelectedIndex == 14)
                { MessageBox.Show("150.1 Km /2 h 57min"); }
                if (cboDist.SelectedIndex == 15)
                { MessageBox.Show("118.1 Km /2 h 51min"); }
            }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
        }

        private void cboTickt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTickt.SelectedIndex == 0)
            { MessageBox.Show("Adults:-Rs.30 / Children(5-12yrs):-Rs.05");}
            if (cboTickt.SelectedIndex == 1)
            { MessageBox.Show("Adults:-Rs.1500"); }
        }

        private void PeraBotGa_Load(object sender, EventArgs e)
        {

        }
        }
    }


