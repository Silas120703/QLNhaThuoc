using System.Drawing;
using System.Windows.Forms;
using System;

namespace GUI
{
    partial class fTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.lblTenNhanVien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 49);
            this.panel1.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.AutoSize = true;
            this.btnDangXuat.BackColor = System.Drawing.Color.Teal;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDangXuat.Location = new System.Drawing.Point(1268, 6);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(90, 34);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.ForeColor = System.Drawing.Color.Snow;
            this.lblTenNhanVien.Location = new System.Drawing.Point(1126, 15);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(50, 16);
            this.lblTenNhanVien.TabIndex = 4;
            this.lblTenNhanVien.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(1047, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xin Chào ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(280, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 36);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chi nhánh Đà Nẵng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG BÁN THUỐC";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button12);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 698);
            this.panel3.TabIndex = 0;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button12.Location = new System.Drawing.Point(3, 408);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(250, 42);
            this.button12.TabIndex = 11;
            this.button12.Text = "Quản Lý Tài Khoản";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button11.Location = new System.Drawing.Point(3, 369);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(250, 42);
            this.button11.TabIndex = 10;
            this.button11.Text = "Quản Lý Tiền Lương";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button10.Location = new System.Drawing.Point(1, 328);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(250, 42);
            this.button10.TabIndex = 9;
            this.button10.Text = "Quản Lý Nhân Viên";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(3, 286);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(250, 42);
            this.button9.TabIndex = 8;
            this.button9.Text = "Quản Lý Nhà Cung Cấp";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(3, 244);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(250, 42);
            this.button8.TabIndex = 7;
            this.button8.Text = "Quản Lý Khách Hàng";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(3, 204);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(250, 42);
            this.button7.TabIndex = 6;
            this.button7.Text = "Chăm Sóc Khách Hàng";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(3, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(250, 42);
            this.button6.TabIndex = 5;
            this.button6.Text = "Chăm Sóc Khách Hàng";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(3, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "Báo Cáo - Thống Kê";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(3, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "Quản Lý Hóa Đơn";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(3, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Quản Lý Kho";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(3, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Quản Lý Sản Phẩm";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quản Lý Đơn Đặt Hàng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(257, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1101, 683);
            this.panel4.TabIndex = 1;
            // 
            // fTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1364, 489);
            this.Name = "fTrangChu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTrangChu_FormClosing);
            this.Load += new System.EventHandler(this.fTrangChu_Load);
            this.Resize += new System.EventHandler(this.fTrangChu_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Button btnDangXuat;

        private void fTrangChu_Resize(object sender, EventArgs e)
        {
            // Điều chỉnh kích thước của panel1
            panel1.Width = this.ClientSize.Width;
            panel1.Height = 49;

            // Điều chỉnh kích thước của panel3
            panel3.Width = 253;
            panel3.Height = this.ClientSize.Height - 49;

            // Điều chỉnh kích thước của panel4
            panel4.Location = new Point(257, 54);
            panel4.Width = this.ClientSize.Width - 257;
            panel4.Height = this.ClientSize.Height - 54;
            // Điều chỉnh kích thước của panel1
            panel1.Width = this.ClientSize.Width;
            panel1.Height = 49;

            // Điều chỉnh kích thước của panel3
            panel3.Width = 253;
            panel3.Height = this.ClientSize.Height - 49;

            // Điều chỉnh kích thước của panel4
            panel4.Location = new Point(257, 54);
            panel4.Width = this.ClientSize.Width - 257;
            panel4.Height = this.ClientSize.Height - 54;

            // Điều chỉnh vị trí và kích thước của label "Xin chào" và button "Đăng xuất"
            label3.Location = new Point(this.ClientSize.Width - 220, 15);
            btnDangXuat.Location = new Point(this.ClientSize.Width - 120, 6);
            lblTenNhanVien.Location = new Point(this.ClientSize.Width - 320, 15);
        }

        private void fTrangChu_Load(object sender, EventArgs e)
        {
            // Thiết lập kích thước ban đầu của các panel và control
            panel1.Width = this.ClientSize.Width;
            panel1.Height = 49;

            panel3.Width = 253;
            panel3.Height = this.ClientSize.Height - 49;

            panel4.Location = new Point(257, 54);
            panel4.Width = this.ClientSize.Width - 257;
            panel4.Height = this.ClientSize.Height - 54;

            // Thiết lập thuộc tính WindowState của form thành FormWindowState.Maximized
            this.WindowState = FormWindowState.Maximized;
        }

        private void fTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Normal;
            }
        }

           
        
    }
}