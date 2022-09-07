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
    public partial class frmSriDalada : Form
    {
        public frmSriDalada()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmSriDalada_Load(object sender, EventArgs e)
        {

        }

        private void cboDistance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDistance.SelectedIndex == 0)
            { MessageBox.Show("116.3Km  / 4h 2min"); }
            if (cboDistance.SelectedIndex ==1)
            { MessageBox.Show("133Km / 3h 56min"); }
            if (cboDistance.SelectedIndex ==2 )
            { MessageBox.Show("134.7Km /3h 47min"); }
if (cboDistance.SelectedIndex ==3)
            { MessageBox.Show("119.5Km / 3h 46min"); }
if (cboDistance.SelectedIndex ==4)
            { MessageBox.Show("104Km / 3h 5min"); }
if (cboDistance.SelectedIndex ==5)
            { MessageBox.Show("1.3Km / 9min"); }
if (cboDistance.SelectedIndex ==6)
            { MessageBox.Show("197.2Km / 4h 50min"); }
            if (cboDistance.SelectedIndex ==7)
            { MessageBox.Show("177.5Km/ 3h 54min"); }
if (cboDistance.SelectedIndex ==8)
            { MessageBox.Show("223Km / 4h 50min"); }
if (cboDistance.SelectedIndex ==9)
            { MessageBox.Show("178.2Km / 3h 53min"); }
if (cboDistance.SelectedIndex ==10)
            { MessageBox.Show("182.4Km / 4h 41min"); }
if (cboDistance.SelectedIndex ==11)
            { MessageBox.Show("315.8Km / 6h 8min"); }
if (cboDistance.SelectedIndex ==12)
            { MessageBox.Show("104.2Km / 3h 9min");}
if (cboDistance.SelectedIndex ==13)
            { MessageBox.Show("72.6Km / 2h 8min"); }
if (cboDistance.SelectedIndex ==14)
            { MessageBox.Show("136.3Km / 3h 15min"); }
if (cboDistance.SelectedIndex ==15)
            { MessageBox.Show("121.7Km / 3h 25min"); }


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void cboTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTicket.SelectedIndex== 0)
            { MessageBox.Show("Free For Locals");}
            if (cboTicket.SelectedIndex == 1)
            { MessageBox.Show("Aults :- Rs.1500,SAARC:-Rs.1000/ Children :- Free"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
