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
    public partial class Diary : Form
    {
        public Diary()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if ((txtName.Text).Equals("sliit"))
            {
                if ((txtPassWord.Text).Equals("123"))
                {
                    Form5 add = new Form5();
                    add.Show();
                }
            }
            else
            {
                MessageBox.Show("Name or Password Error");
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPassWord.Clear();
        }
    }
}
