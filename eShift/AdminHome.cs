using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShift
{
    public partial class AdminHome : Form
    {
        public AdminHome(string email)
        {
            InitializeComponent();
            label2.Text = "";
            label2.Text = email;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerDetails customerDetails = new CustomerDetails(label2.Text);
            this.Hide();
            customerDetails.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDetails adminDetails = new AdminDetails(label2.Text);
            this.Hide();
            adminDetails.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApproveJobs approveJobs = new ApproveJobs(label2.Text);
            this.Hide();
            approveJobs.Show();
        }
    }
}
