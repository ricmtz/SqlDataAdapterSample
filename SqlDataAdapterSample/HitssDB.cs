using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAdapterSample
{
    class HitssDB
    {
        public String ConnectionString { get; private set; }
        private SqlConnection connection;

        public HitssDB(String conString)
        {
            this.ConnectionString = conString;
            this.connection = new SqlConnection(ConnectionString = this.ConnectionString);
        }

        public DataSet GetAllEmployees()
        {
            DataSet employees = new DataSet();
            try
            {
                this.connection.Open();
                string query = "SELECT * FROM Employee";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);
                adapter.Fill(employees);
                connection.Close();
            } catch (Exception ex) {
                throw ex;
            }
            return employees;
        }

    }
}
