using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOForm.Conection
{
    /// <summary>
    /// Lớp MyController điều khiển thao tác trên cơ sở dữ liệu dữ liệu và chiến thuật đóng mở kết nối
    /// là một lớp trừu tượng chứa một thể hiện của DatabaseConnection và cung cấp hai phương thức bảo vệ để mở và đóng kết nối
    /// là một lớp trừu tượng kế thừa interface DBController chứa các phương thức định nghĩa sẵn để thao tác trên cơ sở dữ liệu
    /// </summary>
    public abstract class MyController : DBController
    {
        /// <summary>
        /// Đây là một chiến lược tốt để quản lý kết nối cơ sở dữ liệu. Bằng cách đặt nó như một thành viên bảo vệ, các lớp kế thừa có thể sử dụng nó để mở và đóng kết nối.
        /// </summary>
        protected DatabaseConnection dbConnection;
        /// <summary>
        /// Property này cho phép bạn truy cập và chỉnh sửa listgridview từ các lớp kế thừa. Điều này có thể hữu ích nếu bạn muốn hiển thị dữ liệu từ cơ sở dữ liệu lên giao diện người dùng.
        /// </summary>
        protected DataTable listgridview;
        /// <summary>
        /// SqlDataAdapter là một đối tượng bridge giữa DataSet và SQL Server để lấy dữ liệu và lưu dữ liệu. SqlDataAdapter hoạt động với SqlCommand để lấy dữ liệu từ cơ sở dữ liệu và đổ vào DataSet. Khi bạn thực hiện các thao tác Cập nhật hoặc Xóa trên dữ liệu trong DataSet thì SqlDataAdapter sẽ thực hiện việc cập nhật này lên cơ sở dữ liệu. Property Adapter cho phép bạn truy cập và chỉnh sửa adapter từ các lớp kế thừa.
        /// </summary>
        protected SqlDataAdapter adapter;
        /// <summary>
        /// Đối tượng SqlCommand biểu diễn một câu lệnh SQL hoặc một thủ tục đã lưu để thực thi trên SQL Server. Các lớp kế thừa có thể sử dụng nó để thực thi các câu lệnh SQL. Property Sql cho phép bạn truy cập và chỉnh sửa sql từ các lớp kế thừa.
        /// </summary>
        protected SqlCommand sql;


        public MyController(string connectionString)
        {
            dbConnection = new DatabaseConnection(connectionString);
        }

        protected SqlConnection OpenConnection()
        {
            return dbConnection.OpenConnection();
        }

        protected void CloseConnection()
        {
            dbConnection.CloseConnection();
        }
        /// <summary>
        /// Đây là một chiến lược tốt để quản lý kết nối cơ sở dữ liệu. Bằng cách đặt nó như một thành viên bảo vệ, các lớp kế thừa có thể sử dụng nó để mở và đóng kết nối.
        /// </summary>
        protected DatabaseConnection DbConnection { get => dbConnection; set => dbConnection = value; }
        /// <summary>
        /// Property này cho phép bạn truy cập và chỉnh sửa listgridview từ các lớp kế thừa. Điều này có thể hữu ích nếu bạn muốn hiển thị dữ liệu từ cơ sở dữ liệu lên giao diện người dùng.
        /// </summary>
        protected DataTable Listgridview { get => listgridview; set => listgridview = value; }
        /// <summary>
        /// SqlDataAdapter là một đối tượng bridge giữa DataSet và SQL Server để lấy dữ liệu và lưu dữ liệu. SqlDataAdapter hoạt động với SqlCommand để lấy dữ liệu từ cơ sở dữ liệu và đổ vào DataSet. Khi bạn thực hiện các thao tác Cập nhật hoặc Xóa trên dữ liệu trong DataSet thì SqlDataAdapter sẽ thực hiện việc cập nhật này lên cơ sở dữ liệu. Property Adapter cho phép bạn truy cập và chỉnh sửa adapter từ các lớp kế thừa.
        /// </summary>
        protected SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        /// <summary>
        /// Đối tượng SqlCommand biểu diễn một câu lệnh SQL hoặc một thủ tục đã lưu để thực thi trên SQL Server. Các lớp kế thừa có thể sử dụng nó để thực thi các câu lệnh SQL. Property Sql cho phép bạn truy cập và chỉnh sửa sql từ các lớp kế thừa.
        /// </summary>
        protected SqlCommand Sql { get => sql; set => sql = value; }

        public abstract void Delete(object id);


        public abstract void Insert(object sender);


        public abstract void SelectAll();


        public abstract DataTable SelectByID(object id);


        public abstract void Update(object sender);
    }

}
