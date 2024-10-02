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
    }
}
