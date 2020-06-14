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

namespace Calender
{
    public partial class SIGNUP : Form
    {
        string phonePattern = @"^[0-9]{10}$";
        string emailPattern = @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$";
        string passPattern = @"^(?=.*?[A-Z])(?=(.*[a-z]){1,})(?=(.*[\d]){1,})(?=(.*[\W]){1,})(?!.*\s).{8,30}$";
        public SIGNUP()
        {
            InitializeComponent();
        }

        private void fname_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(fname.Text)==true)
            {
                fname.Focus();
                errorProvider1.SetError(this.fname, "Please fill the First Name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(char.IsLetter(ch)==true )
            {
                e.Handled = false;
            }
            else if(ch==8)
            {
                e.Handled = false;
            }
            else if(ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void lname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lname.Text) == true)
            {
                lname.Focus();
                errorProvider2.SetError(this.lname, "Please fill the Last Name");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
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
            if(gender.SelectedItem == null)
            {
                gender.Focus();
                errorProvider3.SetError(this.gender, "Please Select Gender");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void phone_Leave(object sender, EventArgs e)
        {
            if(Regex.IsMatch(phone.Text,phonePattern)== false)
            {
                phone.Focus();
                errorProvider4.SetError(this.phone, "Invalid Phone");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(char.IsDigit(ch) == true)
            {
                e.Handled = false;
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

        private void email_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(email.Text, emailPattern) == false)
            {
                email.Focus();
                errorProvider5.SetError(this.email, "Invalid Email");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(pass.Text,passPattern) == false)
            {
                pass.Focus();
                errorProvider6.SetError(this.pass, "Atleast 8 Characters\nUppercase\nLowercase\nDigit\nSpecial Character");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void cpass_Leave(object sender, EventArgs e)
        {
            if(pass.Text!=cpass.Text)
            {
                cpass.Focus();
                errorProvider7.SetError(this.cpass, "Password Not Matched !!!");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fname.Text) == true)
            {
                fname.Focus();
                errorProvider1.SetError(this.fname, "Please fill the First Name");
            }
            else if (string.IsNullOrEmpty(lname.Text) == true)
            {
                lname.Focus();
                errorProvider2.SetError(this.lname, "Please fill the Last Name");
            }
            else if (gender.SelectedItem == null)
            {
                gender.Focus();
                errorProvider3.SetError(this.gender, "Please Select Gender");
            }
            else if (Regex.IsMatch(phone.Text, phonePattern) == false)
            {
                phone.Focus();
                errorProvider4.SetError(this.phone, "Invalid Phone");
            }
            else if (Regex.IsMatch(email.Text, emailPattern) == false)
            {
                email.Focus();
                errorProvider5.SetError(this.email, "Invalid Email");
            }
            else if (Regex.IsMatch(pass.Text, passPattern) == false)
            {
                pass.Focus();
                errorProvider6.SetError(this.pass, "Atleast 8 Characters\nUppercase\nLowercase\nDigit\nSpecial Character");
            }
            else if (pass.Text != cpass.Text)
            {
                cpass.Focus();
                errorProvider7.SetError(this.cpass, "Password Not Matched !!!");
            }
            else
            {
                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                string query2 = "select * from signup where EMAIL=@email";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("email", email.Text);

                con.Open();
                SqlDataReader rd = cmd2.ExecuteReader();
                if (rd.HasRows == true)
                {
                    MessageBox.Show("Email Id already Exists", "Faliure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
                else
                {
                    con.Close();
                    string query = "insert into signup values(@fname,@lname,@gender,@phone,@email,@pass)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@fname", fname.Text);
                    cmd.Parameters.AddWithValue("@lname", lname.Text);
                    cmd.Parameters.AddWithValue("@gender", gender.SelectedItem);
                    cmd.Parameters.AddWithValue("@phone", phone.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@pass", pass.Text);

                    string query3 = "insert into login_table values(@username,@pass)";
                    SqlCommand cmd3 = new SqlCommand(query3, con);
                    cmd3.Parameters.AddWithValue("@username", email.Text);
                    cmd3.Parameters.AddWithValue("@pass", pass.Text);

                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    int b = cmd3.ExecuteNonQuery();
                    if (a > 0 && b>0)
                    {
                        MessageBox.Show("Registered Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registration Failed !!", "Faliure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            fname.Clear();
            lname.Clear();
            gender.SelectedItem = null;
            phone.Clear();
            email.Clear();
            pass.Clear();
            cpass.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LOGIN page = new LOGIN();
            page.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
