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
    public partial class CustomerHome : Form
    {
        public CustomerHome(string email)
        {
            InitializeComponent();
            label2.Text = "";
            label2.Text = email;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerRequests customerRequests = new CustomerRequests(label2.Text);
            this.Hide();
            customerRequests.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewRequest newRequest = new NewRequest(label2.Text);
            this.Hide();
            newRequest.Show();
        }
    }
}
