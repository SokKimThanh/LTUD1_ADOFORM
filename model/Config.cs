using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOForm
{
    public class Config
    {
        private string server = "server=.;";
        private string database = "database=QUANLYBANHANG;";
        private string pwd = "pwd=;";
        private string uid = "uid=SOKTHANHPC\\Sok Kim Thanh;";
        private string integratedsecurity = "integrated security=true;";

        public string CapQuyenTruyCapSQL()
        {
            return server + database + pwd + uid + integratedsecurity;
        }
    }
}
