using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOForm.Connection
{
    /// <summary>
    /// Lớp DBController là lớp định nghĩa các thao tác trên cơ sở dữ liệu
    /// 11/07/2023
    /// </summary>
    internal interface DBController
    {
        /// <summary>
        /// Thao tác thêm
        /// </summary>
        /// <param name="sender">Tên lớp</param>
        public void Insert(object sender);
        /// <summary>
        /// Thao tác sửa
        /// </summary>
        /// <param name="sender">Tên lớp</param>
        public void Update(object sender);
        /// <summary>
        /// Thao tác xóa
        /// </summary>
        /// <param name="id">mã</param>
        public void Delete(object id);
        /// <summary>
        /// Thao tác liệt kê
        /// </summary> 
        public void SelectAll();
        /// <summary>
        /// Thao tác tìm kiếm
        /// </summary>
        /// <param name="id">Mã</param>
        /// <returns>Trả về một đối tượng của một lớp</returns>
        public DataTable SelectByID(object id);
        /// <summary>
        /// là một phương thức của DBController mà bạn có thể sử dụng để chuyển đổi một DataRow thành một đối tượng User. Bạn chỉ cần truyền vào một DataRow và nó sẽ trả về một đối tượng User tương ứng.
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public object FromDataRow(DataRow row);
    }
}
