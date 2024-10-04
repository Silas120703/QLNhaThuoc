using BLL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class fQLKhachHang : Form
    {
        public fQLKhachHang()
        {
            InitializeComponent();
        }

        private void fQLKhachHang_Load(object sender, EventArgs e)
        {
            LoadData(); // Load dữ liệu khi form cha được mở
            formatGridView();
        }

        // Phương thức LoadData để lấy dữ liệu khách hàng
        public void LoadData()
        {
            BusinessLogic businessLogic = new BusinessLogic();
            DataTable dt = businessLogic.GetKhachHang();
            dataGridView1.DataSource = dt;
        }

        // Xử lý khi người dùng double click vào 1 hàng trong DataGridView
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy mã khách hàng từ dòng được chọn
            try{
                int maKhachHang = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                // Tạo form con chỉnh sửa khách hàng và truyền mã khách hàng vào
                fChinhSuaKhachHang f = new fChinhSuaKhachHang(maKhachHang);

                // Đăng ký sự kiện FormClosed để load lại dữ liệu sau khi đóng form con
                f.FormClosed += (s, args) => LoadData();

                f.ShowDialog(); // Mở form con
            }
            catch(Exception)
            {

            }
            
        }
        public void formatGridView()
        {
            dataGridView1.Dock = DockStyle.Fill; // Hiển thị toàn màn hình
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự động điều chỉnh kích thước cột
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Tự động điều chỉnh kích thước hàng
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 16); // Tăng kích thước chữ
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize; // Tự động điều chỉnh kích thước hàng
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold); // Tăng kích thước chữ cho tiêu đề cột
            dataGridView1.ColumnHeadersHeight = 30; // Tăng kích thước tiêu đề cột
            dataGridView1.RowHeadersDefaultCellStyle.Font = new Font("Arial", 16); // Tăng kích thước chữ cho tiêu đề hàng
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders; // Tự động điều chỉnh kích thước tiêu đề hàng
            dataGridView1.RowHeadersWidth = 100; // Tăng kích thước tiêu đề hàng
            dataGridView1.AllowUserToResizeRows = true; // Cho phép người dùng thay đổi kích thước hàng
            dataGridView1.AllowUserToResizeColumns = true; // Cho phép người dùng thay đổi kích thước cột
            dataGridView1.AllowUserToAddRows = false; // Không cho phép người dùng thêm hàng mới
            dataGridView1.AllowUserToDeleteRows = false; // Không cho phép người dùng xóa hàng
            dataGridView1.ReadOnly = true; // Không cho phép người dùng chỉnh sửa dữ liệu


        }
    }
}
 