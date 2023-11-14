using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;

namespace eShift
{
    public partial class customer_regi : Form
    {
        public object MeessageBox { get; private set; }

        public customer_regi()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=eShift;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[customer]
           ([customerName]
           ,[customerEmail]
           ,[customerPassword])
     VALUES
           ('" + textBox1.Text + "', '" + txtemail.Text + "', '" + textBox4.Text + "')", Con);
                Con.Open();
                cmd.ExecuteNonQuery();
                Con.Close();
            MessageBox.Show("Registration Successfully");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
