using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class BusinessLogic
    {
        DataAccess dal = new DataAccess();

        //public DataTable GetAllUsers()
        //{
        //    string query = "SELECT * FROM Users";
        //    return dal.GetData(query);
        //}
        public DataTable GetLuong()
        {
            return dal.GetLuongData();
        }
        public bool CheckConnection()
        {
            return dal.TestConnection();
        }
        public bool Login(string username, string password)
        {
            return dal.CheckLogin(username, password);
        }
        public string GetTenNhanVien(string username, string password)
        {
            // Gọi phương thức từ tầng DAL để lấy tên nhân viên
            return dal.GetTenNhanVien(username, password);
        }

        public DataTable GetNguoiDung()
        {
            return dal.GetNguoiDung();
        }

        public DataTable GetKhachHang()
        {
            return dal.GetKhachHang();
        }
        public DataTable GetKhachHang(int  maKhachHang)
        {
            return dal.GetKhachHang(maKhachHang);
        }
        public Boolean UpdateKhachHang(int maKhachHang, string tenKhachHang, string diaChi,string email, string soDienThoai)
        {
            return dal.UpdateKhachHang(maKhachHang,tenKhachHang,diaChi,email,soDienThoai);
        }


    }
    

}
