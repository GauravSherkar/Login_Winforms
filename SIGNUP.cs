using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.SqlClient;

namespace SIGNUP_WITH_LOGIN
{
    public partial class SIGNUP : Form
    {
        string pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9._]+$";
        string passpattern = @"^(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        public SIGNUP()
        {
            InitializeComponent();
        }

        private void SIGNUP_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //id.Text = " ";
            //name.Text = " ";
            //fname.Text = " ";
            //surname.Text = " ";
            //gender.Text = " ";
            //email.Text = " ";
            //standard.Value = 0;
            //pass.Text = " ";
            //repass.Text = " ";
            id.Clear();
            name.Clear();
            fname.Clear();
            surname.Clear();
            gender.SelectedItem=null;
            standard.Value = 0;
            email.Clear();
            pass.Clear();
            repass.Clear();


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id.Text)==true)
            {
                id.Focus();
                errorProvider1.SetError(this.id,"PLease filled the id");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch)==true)
            {
                e.Handled = false;//
            }
            else if(ch==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text) == true)
            {
                name.Focus();
                errorProvider2.SetError(this.name, "PLease filled the name");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsLetter(ch) == true)
            {
                e.Handled = false;//
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if(ch==32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void fname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fname.Text) == true)
            {
                name.Focus();
                errorProvider3.SetError(this.fname, "PLease filled the fullname");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsLetter(ch) == true)
            {
                e.Handled = false;//
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void surname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(surname.Text) == true)
            {
                surname.Focus();
                errorProvider4.SetError(this.surname, "PLease filled the surname");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsLetter(ch) == true)
            {
                e.Handled = false;//
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void gender_Leave(object sender, EventArgs e)
        {
            if (gender.SelectedItem==null)
            {
             //   gender.Focus();
                errorProvider5.SetError(this.gender,"Please select Gender");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void standard_Leave(object sender, EventArgs e)
        {
            if (standard.Value==0)
            {
                standard.Focus();
                errorProvider6.SetError(this.standard,"Please select a class");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(email.Text,pattern)==false)
            {
                email.Focus();
                errorProvider7.SetError(this.email,"Invalid email");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(pass.Text,passpattern)==false)
            {
                pass.Focus();
                errorProvider8.SetError(this.pass,"Uppercase ,Lowercase ,Numbers , Symbol");
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void repass_Leave(object sender, EventArgs e)
        {
            if (pass.Text!=repass.Text)
            {
                repass.Focus();
                errorProvider9.SetError(this.repass,"Password is not match");
            }
            else
            {
                errorProvider9.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id.Text)==true)
            {
                id.Focus();
                errorProvider1.SetError(this.id,"Please fiiled The id");
            }
            else if (string.IsNullOrEmpty(name.Text) == true)
            {
                name.Focus();
                errorProvider2.SetError(this.name, "Please filled the name");
            }
            else if (string.IsNullOrEmpty(fname.Text) == true)
            {
                fname.Focus();
                errorProvider3.SetError(this.fname, "Please filled the fullname");
            }

            else if (string.IsNullOrEmpty(surname.Text) == true)
            {
                surname.Focus();
                errorProvider4.SetError(this.surname, "Please filled the Surname");
            }
            else if (gender.SelectedItem == null)
            {
                //   gender.Focus();
                errorProvider5.SetError(this.gender, "Please select Gender");
            }
            else if (standard.Value == 0)
            {
                standard.Focus();
                errorProvider6.SetError(this.standard, "Please select a class");
            }
            else if (Regex.IsMatch(email.Text, pattern) == false)
            {
                email.Focus();
                errorProvider7.SetError(this.email, "Invalid email");
            }
            else if (Regex.IsMatch(pass.Text, passpattern) == false)
            {
                pass.Focus();
                errorProvider8.SetError(this.pass, "Uppercase ,Lowercase ,Numbers , Symbol");
            }
            else if (pass.Text != repass.Text)
            {
                repass.Focus();
                errorProvider9.SetError(this.repass, "Password is not match");
            }
            else
            {

                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                string query2 = "Select * from signup where ID=@id";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@ID", id.Text);
                con.Open();
                SqlDataReader rd=  cmd2.ExecuteReader();
                if (rd.HasRows == true)
                {
                    MessageBox.Show(id.Text + "ID allready exists", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                else
                {
                    con.Close();
                    string query = "insert into signup values(@ID,@NAME,@FNAME,@SURNAME,@GENDER,@CLASS,@EMAIL,@PASS)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", id.Text);
                    cmd.Parameters.AddWithValue("@NAME", name.Text);
                    cmd.Parameters.AddWithValue("@FNAME", fname.Text);
                    cmd.Parameters.AddWithValue("@SURNAME", surname.Text);
                    cmd.Parameters.AddWithValue("@GENDER", gender.SelectedItem);
                    cmd.Parameters.AddWithValue("@CLASS", standard.Value);
                    cmd.Parameters.AddWithValue("@EMAIL", email.Text);
                    cmd.Parameters.AddWithValue("@PASS", pass.Text);

                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Registered Sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Your Email is: " + email.Text + " \n \n " + "Your password is:  " + pass.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();//signup form hide
                        LOGIN Page = new LOGIN();
                        Page.Show();
                    }
                    else
                    {
                        MessageBox.Show("Registered failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }
               // MessageBox.Show("WELCOME");
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        { 
            
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
