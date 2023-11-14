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
    public partial class ApproveJobs : Form
    {
        Connection connection = new Connection();
        public ApproveJobs(string email)
        {
            InitializeComponent();
            label2.Text = "";
            label2.Text = email;
            updateGrid();
        }

        private void updateGrid()
        {
            SqlCommand com = new SqlCommand("getAllJobs", connection.conn);
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

        private void button2_Click(object sender, EventArgs e)
        {
            int jobID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["jobID"].Value);
            connection.conn.Open();
            SqlCommand cmd = new SqlCommand("acceptRequest", connection.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@jobID", jobID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Request Approved successfully!!!", "Approve Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.conn.Close();
            updateGrid();
        }
    }
}
