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
    public partial class Other : Form
    {
        public Other()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTOT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTOT.SelectedIndex == 0)
            { txtANS.Text = (Convert.ToDouble(txtLKR.Text) * Convert.ToDouble(176.56)).ToString(); }
            if (cboTOT.SelectedIndex == 1)
            { txtANS.Text=(Convert.ToInt32(txtLKR.Text)/Convert.ToDouble(176.56)).ToString();}
        }

        private void cboCon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCon.SelectedIndex==0)
            { txtCon.Text = (Convert.ToDecimal(txtVal.Text) / Convert.ToDecimal(1.609)).ToString(); }
            if (cboCon.SelectedIndex == 1)
            { txtCon.Text = (Convert.ToDecimal(txtVal.Text) * Convert.ToDecimal(1.609)).ToString(); }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Other_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            map form = new map();
            form.Show();
        }
    }
}
