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
    public partial class fTienLuong : Form
    {
        private BusinessLogic luongBusiness = new BusinessLogic();
        private DataTable dtLuong; 
        public fTienLuong()
        {
            InitializeComponent();
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            formatGridView();
            timer1.Start();
            // Lấy dữ liệu từ bảng luong thông qua tầng BLL
            dtLuong = luongBusiness.GetLuong();

            // Gán dữ liệu vào DataGridView
            if (dtLuong != null && dtLuong.Rows.Count > 0)
            {
                // Gán dữ liệu từ biến dtLuong vào DataGridView
                dataGridView1.DataSource = dtLuong;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            // Hiển thị tháng và năm hiện tại trên Label
            label1.Text = now.ToString("MM/yyyy");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
