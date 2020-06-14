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
    public partial class newBook : Form
    {
        public newBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button2.BackColor = Color.LimeGreen;
            button3.BackColor = Color.LimeGreen;
            button4.BackColor = Color.LimeGreen;
            button5.BackColor = Color.LimeGreen;
            button6.BackColor = Color.LimeGreen;
            timee.Clear();
            timee.Text = button1.Text.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
            button1.BackColor = Color.LimeGreen;
            button3.BackColor = Color.LimeGreen;
            button4.BackColor = Color.LimeGreen;
            button5.BackColor = Color.LimeGreen;
            button6.BackColor = Color.LimeGreen;
            timee.Clear();
            timee.Text = button2.Text.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Yellow;
            button2.BackColor = Color.LimeGreen;
            button1.BackColor = Color.LimeGreen;
            button4.BackColor = Color.LimeGreen;
            button5.BackColor = Color.LimeGreen;
            button6.BackColor = Color.LimeGreen;
            timee.Clear();
            timee.Text = button3.Text.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Yellow;
            button2.BackColor = Color.LimeGreen;
            button3.BackColor = Color.LimeGreen;
            button1.BackColor = Color.LimeGreen;
            button5.BackColor = Color.LimeGreen;
            button6.BackColor = Color.LimeGreen;
            timee.Clear();
            timee.Text = button4.Text.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Yellow;
            button2.BackColor = Color.LimeGreen;
            button3.BackColor = Color.LimeGreen;
            button4.BackColor = Color.LimeGreen;
            button1.BackColor = Color.LimeGreen;
            button6.BackColor = Color.LimeGreen;
            timee.Clear();
            timee.Text = button5.Text.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Yellow;
            button2.BackColor = Color.LimeGreen;
            button3.BackColor = Color.LimeGreen;
            button4.BackColor = Color.LimeGreen;
            button5.BackColor = Color.LimeGreen;
            button1.BackColor = Color.LimeGreen;
            timee.Clear();
            timee.Text = button6.Text.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Booking bk = new Booking();
            bk.Show();
            this.Hide();
        }

        private void book_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into booking values(@fname,@email,@datee,@timee)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@fname", fname.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@datee", datee.Value);
            cmd.Parameters.AddWithValue("@timee", timee.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Booked Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Booking Failed !!", "Faliure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
