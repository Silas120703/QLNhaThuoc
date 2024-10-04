using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class fQuanLiTaiKhoan : Form
    {
        private BusinessLogic BusinessLogic= new BusinessLogic();
        public fQuanLiTaiKhoan()
        {
            InitializeComponent();
        }

        private void fQuanLiTaiKhoan_Load(object sender, EventArgs e)
        {
            DataTable dt = BusinessLogic.GetNguoiDung();
            dataGridView1.DataSource = dt;
            formatGridView();
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

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
