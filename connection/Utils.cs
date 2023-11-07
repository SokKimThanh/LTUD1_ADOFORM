using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOForm.Conection
{
    public class Utils
    {
        private static string connectionString = "Data Source=localhost;Initial Catalog=YourDB; Integrated Security=true";
        public static string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        private static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }

}
