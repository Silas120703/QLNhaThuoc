using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class fChinhSuaKhachHang : Form
    {
        private int maKhachHang;

        public fChinhSuaKhachHang(int maKhachHang)
        {
            InitializeComponent();

            this.maKhachHang = maKhachHang;

            // Lấy thông tin khách hàng từ database
            BusinessLogic businessLogic = new BusinessLogic();
            DataTable dt = businessLogic.GetKhachHang(maKhachHang);

            // Hiển thị thông tin khách hàng lên form
            lbMaKhachHang.Text = dt.Rows[0][0].ToString();
            txtTenKhachHang.Text = dt.Rows[0][1].ToString();
            txtDiaChi.Text = dt.Rows[0][2].ToString();
            txtEmail.Text = dt.Rows[0][3].ToString();
            lbSoDienThoai.Text = dt.Rows[0][4].ToString();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            // Cập nhật thông tin khách hàng vào database
            BusinessLogic businessLogic = new BusinessLogic();
            if (businessLogic.UpdateKhachHang(maKhachHang, txtTenKhachHang.Text, txtDiaChi.Text, txtEmail.Text, lbSoDienThoai.Text))
            {
                MessageBox.Show("Chỉnh sửa thành công!");
                this.Close(); // Đóng form sau khi chỉnh sửa thành công
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thất bại!");
            }
        }

        private void fChinhSuaKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
