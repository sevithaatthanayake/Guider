using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Project_SLIIT
{
    public partial class Form5 : Form
    {   
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Acer v5\Desktop\Database41.accdb");
        int count = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Table1 values ('"+textBox1.Text+"','"+textBox2.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record inserted succesfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Table1 where name='"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record deleted succesfully");
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Table1 set name='"+textBox2.Text+"'  where name='"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record updated succesfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            count = 0;
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table1 where name='"+textBox1.Text+"' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());

            dataGridView1.DataSource = dt;
            con.Close();

            if (count == 0)
            {
                MessageBox.Show("Record Not Found");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
