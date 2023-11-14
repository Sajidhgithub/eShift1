using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace eShift
{
    public partial class AdminLogin : Form
    {
        Connection conn = new Connection();
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

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
            if (conn.isAdmin(email, password))
            {
                AdminHome home = new AdminHome(email);
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
    }
}
