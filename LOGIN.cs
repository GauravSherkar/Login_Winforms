using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SIGNUP_WITH_LOGIN
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SIGNUP su = new SIGNUP();
            this.Hide();
            su.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string query2 = "Select * from signup where Email=@Email and PASS=@PASS";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.Parameters.AddWithValue("@EMAIL", textBox1.Text);
            cmd2.Parameters.AddWithValue("@PASS", textBox2.Text);
            con.Open();
            SqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows==true)
            {
                MessageBox.Show("LOGIN SUCCESSFULLY !! ","SUCCESS",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("LOGIN  FAILED !! ", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
