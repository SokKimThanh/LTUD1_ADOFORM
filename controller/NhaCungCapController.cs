using ADOForm.Connection;
using System.Data;
using System.Data.SqlClient;

namespace ADOForm
{
    public class NhaCungCapController : MyController
    {

        public NhaCungCapController(string connectionString) : base(connectionString)
        {

        }

        public override void Delete(object id)
        {
            throw new NotImplementedException();
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


                // Thực hiện các thao tác trên cơ sở dữ liệu tại đây
                Sql = new SqlCommand();
                Sql.Connection = conn;
                Sql.CommandText = "sp_nhacungcap_select_all";
                Sql.CommandType = CommandType.StoredProcedure;
                Adapter = new SqlDataAdapter(Sql);
                Adapter.Fill(Listgridview);
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

        public override DataTable SelectByID(object id)
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();


                // Thực hiện các thao tác trên cơ sở dữ liệu tại đây
                Sql = new SqlCommand();
                Sql.Connection = conn;
                Sql.CommandText = "sp_nhacungcap_select_one";
                Sql.CommandType = CommandType.StoredProcedure;

                // bind_param
                SqlParameter ma = new SqlParameter("@ma", id);
                Sql.Parameters.Add(ma);


                Adapter = new SqlDataAdapter(Sql);
                Adapter.Fill(Listgridview);


                dbConnection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return Listgridview;
        }

        public override void Update(object sender)
        {
            throw new NotImplementedException();
        }
    }
}