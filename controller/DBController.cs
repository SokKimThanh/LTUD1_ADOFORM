using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOForm
{
    internal interface DBController
    {
        public bool Insert(object sender);
        public bool Update(object sender);
        public bool Delete(object id);
        /// <summary>
        /// Hỗ trợ tìm tất cả 
        /// </summary>
        /// <returns></returns>
        public DataTable Select();
        /// <summary>
        /// Hỗ trợ tìm 1 dòng
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable SelectOne(object id);
    }
}
