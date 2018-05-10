using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CustomerMaintenance
{
    class MMABooksDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=LAPTOP-57M3IJN1\\SQLEXPRESS;Initial Catalog=MMABooks;Integrated Security=True";
            //string connectionString = "Data Source=(local);Initial Catalog=MMABooks;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
