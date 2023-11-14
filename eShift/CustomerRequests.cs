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
    public partial class CustomerRequests : Form
    {
        Connection connection = new Connection();
        public CustomerRequests(string email)
        {
            InitializeComponent();
            label2.Text = "";
            label2.Text = email;
            SqlCommand com = new SqlCommand("getCustomerRequests", connection.conn);
            com.Parameters.AddWithValue("@email", label2.Text);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da3 = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da3.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerHome customerHome = new CustomerHome(label2.Text);
            this.Hide();
            customerHome.Show();
        }

        private void CustomerRequests_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
