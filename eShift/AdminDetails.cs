using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShift
{
    public partial class AdminDetails : Form
    {
        Connection connection = new Connection();
        public AdminDetails(string email)
        {
            InitializeComponent();
            label2.Text = "";
            label2.Text = email;
            SqlCommand com = new SqlCommand("getAllAdmins", connection.conn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome(label2.Text);
            this.Hide();
            adminHome.Show();
        }
    }
}
