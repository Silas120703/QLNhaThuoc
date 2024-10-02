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
    public partial class fDangNhap : Form
    {
        private DatabaseManager dbManager = new DatabaseManager();
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tb_Sdt.Text;
            string password = tb_Matkhau.Text;

            bool isAuthenticated = dbManager.Login(username, password);

            if (isAuthenticated)
            {
                //MessageBox.Show("Đăng nhập thành công!");
                // Chuyển sang form khác sau khi đăng nhập thành công
                fTrangChu mainForm = new fTrangChu();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại.");
            }
        }
    }
}
