using MySql.Data.MySqlClient;
using System;
using System.Data;
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
                string query = "SELECT COUNT(*) FROM nhanvien WHERE sdt_nhan_vien = @Username AND mat_khau = @Password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result > 0;  // If 1 or more records are found, login is successful
                }
                catch
                {
                    return false;  // Login failed due to error
                }
            }
        }

        public string GetTenNhanVien(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Truy vấn để lấy tên nhân viên dựa trên username và password
                string query = "SELECT ten_nhan_vien FROM nhanvien WHERE sdt_nhan_vien = @Username AND mat_khau = @Password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    object result = cmd.ExecuteScalar();

                    // Nếu kết quả không null, trả về tên nhân viên
                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return null;  // Trả về null nếu không tìm thấy bản ghi
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        // Phương thức lấy dữ liệu từ bảng luong
        public DataTable GetLuongData()
        {
            // Tạo DataTable để chứa dữ liệu
            DataTable dt = new DataTable();

            // Chuỗi truy vấn để lấy các cột cần thiết từ bảng luong
            //string query = "SELECT * FROM luong";
            string query = "SELECT luong.*, nhanvien.ten_nhan_vien FROM luong JOIN nhanvien ON luong.nhanvien_id = nhanvien.nhanvien_id; ";

            //string query = "SELECT luong_id,nhanvien_id, luongcoban, he_so_luong, tong_luong FROM luong";

            // Kết nối với cơ sở dữ liệu
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Tạo MySqlCommand với truy vấn và kết nối
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Sử dụng MySqlDataAdapter để đổ dữ liệu vào DataTable
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);  // Đổ dữ liệu vào DataTable
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có lỗi xảy ra
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            // Trả về DataTable chứa dữ liệu từ bảng luong
            return dt;
        }
        public DataTable GetNguoiDung()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT kh.nguoi_dung_id, kh.sdt_khach_hang, kh.ten_khach_hang, kh.email_khach_hang, kh.dia_chi_khach_hang, nd.user_name, nd.mat_khau FROM khachhang kh INNER JOIN nguoidung nd ON kh.nguoi_dung_id = nd.nguoi_dung_id;";
            //string query= "SELECT luong.*, nhanvien.ten_nhan_vien FROM luong JOIN nhanvien ON luong.nhanvien_id = nhanvien.nhanvien_id; ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return dt;
        }
        public DataTable GetKhachHang()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM khachhang";
            //string query= "SELECT luong.*, nhanvien.ten_nhan_vien FROM luong JOIN nhanvien ON luong.nhanvien_id = nhanvien.nhanvien_id; ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return dt;
        }

        //public DataTable GetKhachHang(string maKhachHang)
        //{
        //    string query = "SELECT * FROM khachhang WHERE ma_khach_hang = @MaKhachHang";
        //    using (MySqlConnection connection = new MySqlConnection(connectionString))
        //    {
        //        MySqlCommand cmd = new MySqlCommand(query, connection);
        //        cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);

        //        DataTable dt = new DataTable();
        //        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        //        adapter.Fill(dt);

        //        return dt;
        //    }
        //}

        public DataTable GetKhachHang(int maKhachHang)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM khachhang WHERE nguoi_dung_id = @MaKhachHang";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);

                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                return dt;
            }
        }

        public Boolean UpdateKhachHang(int  maKhachHang, string tenKhachHang, string diaChi,string email, string soDienThoai)
        {
            string query = "UPDATE khachhang SET ten_khach_hang = @TenKhachHang, dia_chi_khach_hang = @DiaChi,email_khach_hang=@Email, sdt_khach_hang = @SoDienThoai WHERE nguoi_dung_id = @MaKhachHang";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                cmd.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue ("@Email", email);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);

                connection.Open();
                int chk =(int) cmd.ExecuteNonQuery();
                if (chk >= 0)
                {
                   
                    return true;

                }
                connection.Close();
                return false;
                
                
            }
        }

    }
}
