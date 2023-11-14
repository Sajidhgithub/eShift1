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
    public partial class NewRequest : Form
    {
        Connection connection = new Connection();
        public NewRequest(string email)
        {
            InitializeComponent();
            label2.Text = "";
            label2.Text = email;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string noOfLots = textBox1.Text;
            string source = textBox2.Text;
            string destination = textBox3.Text;
            connection.conn.Open();
            SqlCommand cmd = new SqlCommand("addRequest", connection.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", label2.Text);
            cmd.Parameters.AddWithValue("@noOfLots", Convert.ToInt32(noOfLots));
            cmd.Parameters.AddWithValue("@source", source);
            cmd.Parameters.AddWithValue("@destination", destination);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Added successfully!!!", "Add Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.conn.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerHome customerHome = new CustomerHome(label2.Text);
            this.Hide();
            customerHome.Show();
        }
    }
}
