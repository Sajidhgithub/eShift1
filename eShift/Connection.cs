using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShift
{
    internal class Connection
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=eShift;Integrated Security=True");

        public bool isAdmin(string email, string password)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("isAdmin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader dr = cmd.ExecuteReader();
            bool status = dr.HasRows;
            conn.Close();
            return status;
        }

        public bool isCustomer(string email, string password)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("isCustomer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader dr = cmd.ExecuteReader();
            bool status = dr.HasRows;
            conn.Close();
            return status;
        }
    }
}
