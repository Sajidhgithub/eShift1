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
    public partial class CustomerLogin : Form
    {
        Connection conn = new Connection();
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            if (conn.isCustomer(email, password))
            {
                CustomerHome home = new CustomerHome(email);
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Email or password is incorrect!!!!!", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer_regi CL = new customer_regi();
            CL.Show();
        }
    }
}
