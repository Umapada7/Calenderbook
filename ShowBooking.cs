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

namespace Calender
{
    public partial class showBook : Form
    {
        public showBook()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            timee.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Booking bk = new Booking();
            bk.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void book_Click(object sender, EventArgs e)
        {

            if (fname.Text != "" && email.Text != "")
            {
                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                string query = "select timee from booking where fname=@fname and email=@email  and datee=@datee";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@fname", fname.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@datee", datee.Text);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {

                    MessageBox.Show("Booking Found !!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    while (dr.Read())
                    {
                        timee.Text = dr["timee"].ToString();
                    }

                    if (timee.Text==button1.Text)
                    {
                        button1.BackColor = Color.Yellow;
                    }
                    if (timee.Text == button2.Text)
                    {
                        button2.BackColor = Color.Yellow;
                    }
                    if (timee.Text == button3.Text)
                    {
                        button3.BackColor = Color.Yellow;
                    }
                    if (timee.Text == button4.Text)
                    {
                        button4.BackColor = Color.Yellow;
                    }
                    if (timee.Text == button5.Text)
                    {
                        button5.BackColor = Color.Yellow;
                    }
                    if (timee.Text == button6.Text)
                    {
                        button6.BackColor = Color.Yellow;
                    }
                }
                else
                {
                    MessageBox.Show("No Booking Found !!", "FALIURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Fill Both Fields !!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
