using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fTrangChu : Form
    {
        private string tenNhanVien;
        public fTrangChu(string tenNhanVien)
        {
            InitializeComponent();
            this.tenNhanVien = tenNhanVien;
            lblTenNhanVien.Text = tenNhanVien;
        }
        
        public fTrangChu()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fDangNhap dn = new fDangNhap();
            if (this.panel4.Controls.Count > 0)
            {
                this.panel4.Controls.RemoveAt(0); // Xóa form con trước đó (nếu có)
            }
            dn.TopLevel = false;
            panel4.Controls.Add(dn);
            dn.Dock = DockStyle.Fill;
            dn.FormBorderStyle = FormBorderStyle.None;
            dn.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            fTienLuong tl = new fTienLuong();
            if (this.panel4.Controls.Count > 0)
            {
                this.panel4.Controls.RemoveAt(0); // Xóa form con trước đó (nếu có)
            }
            tl.TopLevel = false;
            panel4.Controls.Add(tl);
            tl.Dock = DockStyle.Fill;
            tl.FormBorderStyle = FormBorderStyle.None;
            tl.Show();
        }

        

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            fDangNhap loginForm = new fDangNhap();
            loginForm.Show();

            // Ẩn form hiện tại (fTrangChu)
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            fQuanLiTaiKhoan fQuanLi =new fQuanLiTaiKhoan();
            if (this.panel4.Controls.Count > 0)
            {
                this.panel4.Controls.RemoveAt(0); // Xóa form con trước đó (nếu có)
            }
            fQuanLi.TopLevel = false;
            panel4.Controls.Add(fQuanLi);
            fQuanLi.Dock = DockStyle.Fill;
            fQuanLi.FormBorderStyle = FormBorderStyle.None;
            fQuanLi.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fQLKhachHang fQLKhachHang = new fQLKhachHang();
            if (this.panel4.Controls.Count > 0)
            {
                this.panel4.Controls.RemoveAt(0); // Xóa form con trước đó (nếu có)
            }
            fQLKhachHang.TopLevel = false;
            panel4.Controls.Add(fQLKhachHang);
            fQLKhachHang.Dock = DockStyle.Fill;
            fQLKhachHang.FormBorderStyle = FormBorderStyle.None;
            fQLKhachHang.Show();
        }
    }
}
