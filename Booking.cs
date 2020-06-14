using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calender
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void newBooking_Click(object sender, EventArgs e)
        {
            newBook nb = new newBook();
            nb.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN lg = new LOGIN();
            lg.Show();
            this.Hide();
        }

        private void showBooking_Click(object sender, EventArgs e)
        {
            showBook sb = new showBook();
            sb.Show();
            this.Hide();
        }
    }
}
