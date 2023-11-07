using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOForm
{
    internal class DBConfig
    {
        Config c;
        SqlConnection conn;
        public DBConfig()
        {
            this.c = new Config();
            conn = new SqlConnection(c.CapQuyenTruyCapSQL());
        }
        public SqlConnection GetConnection()
        {
            return this.conn;
        }
    }
}
