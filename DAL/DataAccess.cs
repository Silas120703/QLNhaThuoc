using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
namespace DAL
{
    public class DataAccess
    {
        //private string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;
        string connectionString = "Server=127.0.0.1;Database=k;User ID=root;Password='';SslMode=none;";
        //public DataTable GetData(string query)
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        return dt;
        //    }
        //}
        public bool TestConnection()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool CheckLogin(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM nguoidung WHERE user_name = @Username AND mat_khau = @Password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    int result = (int)cmd.ExecuteScalar();
                    return result == 1;  // Nếu có 1 bản ghi khớp, đăng nhập thành công
                }
                catch
                {
                    return false;  // Đăng nhập thất bại do lỗi
                }
            }
        }

    }
}
