using ADOForm.Connection;
using ADOForm.model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ADOForm.controller
{

    public class UserController : MyController
    {
        public UserController(string connectionString) : base(connectionString)
        {

        }

        public override void Delete(object id)
        {
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("YourDeleteStoredProcedureName", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào SqlCommand
            Sql.Parameters.AddWithValue("@UserId", id);

            // Thực thi SqlCommand
            Sql.ExecuteNonQuery();

            // Đóng kết nối
            CloseConnection();
        }

        public override object FromDataRow(DataRow row)
        {
            return new UserAdo()
            {
                Username = row.Field<string>("username")!,
                Password = row.Field<string>("password")!,
                CreatedDate = row.Field<DateTime>("createdDate")!
            };
        }

        public override void Insert(object sender)
        {
            UserAdo user = (UserAdo)sender;
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("YourInsertStoredProcedureName", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào SqlCommand
            Sql.Parameters.AddWithValue("@Username", user.Username);
            Sql.Parameters.AddWithValue("@Password", user.Password);
            Sql.Parameters.AddWithValue("@CreatedDate", user.CreatedDate);

            // Thực thi SqlCommand
            Sql.ExecuteNonQuery();

            // Đóng kết nối
            CloseConnection();
        }

        public override void SelectAll()
        {
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("YourStoredProcedureName", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Tạo một đối tượng SqlDataAdapter
            Adapter = new SqlDataAdapter(Sql);

            // Tạo một đối tượng DataTable để lưu trữ dữ liệu
            DataSource = new DataTable();

            // Đổ dữ liệu vào DataTable
            Adapter.Fill(DataSource);

            // Đóng kết nối
            CloseConnection();
        }

        public override DataTable SelectByID(object id)
        {
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("YourSelectByIdStoredProcedureName", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào SqlCommand
            Sql.Parameters.AddWithValue("@UserId", id);

            // Tạo một đối tượng SqlDataAdapter
            Adapter = new SqlDataAdapter(Sql);

            // Tạo một đối tượng DataTable để lưu trữ dữ liệu
            DataSource = new DataTable();

            // Đổ dữ liệu vào DataTable
            Adapter.Fill(DataSource);

            // Đóng kết nối
            CloseConnection();

            // Trả về DataTable
            return DataSource;
        }

        public override void Update(object sender)
        {
            UserAdo user = (UserAdo)sender;
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("YourUpdateStoredProcedureName", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào SqlCommand
            Sql.Parameters.AddWithValue("@UserId", user.Userid);
            Sql.Parameters.AddWithValue("@Username", user.Username);
            Sql.Parameters.AddWithValue("@Password", user.Password);
            Sql.Parameters.AddWithValue("@CreatedDate", user.CreatedDate);

            // Thực thi SqlCommand
            Sql.ExecuteNonQuery();

            // Đóng kết nối
            CloseConnection();
        }
    }

}
