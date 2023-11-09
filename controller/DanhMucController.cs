using ADOForm.Connection;
using System.Data;
using System.Data.SqlClient;

namespace ADOForm
{
    internal class DanhMucController : MyController
    {

        public DanhMucController(string connectionString) : base(connectionString)
        {

        }

        public override void Delete(object id)
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_danhmuc_delete", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@UserId", id);

                // Thực thi SqlCommand
                Sql.ExecuteNonQuery();

                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public override object FromDataRow(DataRow row)
        {
            return new DanhMuc()
            {
                Ma = row.Field<string>("ma")!,
                Ten = row.Field<string>("ten")!,
                Ghichu = row.Field<string>("ghichu")!
            };
        }

        public override void Insert(object sender)
        {
            throw new NotImplementedException();
        }

        public override void SelectAll()
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // thực hiện các thao tác trên cơ sở dữ liệu
                Sql = new SqlCommand("sp_danhmuc_select_all", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Tạo đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql);

                // Tạo một đối tượng Database để lưu trữ dữ liệu
                DataSource = new DataTable();

                // đổ dữ liệu vào DataTable
                Adapter.Fill(DataSource);

                //đóng kết nối
                //CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public override DataTable SelectByID(object id)
        {
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_danhmuc_select_one", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào SqlCommand
            Sql.Parameters.AddWithValue("@ma", id);

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
            NhaCungCap o = (NhaCungCap)sender;
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_danhmuc_update", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào SqlCommand
            Sql.Parameters.AddWithValue("@ma", o.Ma);
            Sql.Parameters.AddWithValue("@ten", o.Ten);
            Sql.Parameters.AddWithValue("@ghichu", o.Ghichu);

            // Thực thi SqlCommand
            Sql.ExecuteNonQuery();

            // Đóng kết nối
            CloseConnection();
        }

    }
}
