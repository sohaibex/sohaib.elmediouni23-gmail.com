using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation.Data.Database
{
    public static class OutilConnect
    {
        public static SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Facturation_DB;Integrated Security=True");
        public static DataTable table;
        public static SqlCommand sqlCommand;
        public static SqlDataReader reader;
        public static void Connect()
        {
            if (sqlConnection.State == ConnectionState.Broken || sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
        }
        public static void DeConnect()
        {
            if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
        }

    }
}
