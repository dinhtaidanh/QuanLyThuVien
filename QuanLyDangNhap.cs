using ManHinhChinh.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManHinhChinh
{
    public partial class QuanLyDangNhap : Form
    {
        NhanVienService nhanVienService;
        public QuanLyDangNhap()
        {
            InitializeComponent();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            nhanVienService = new NhanVienService();
            try
            {
                NhanVien nhanVien = nhanVienService.GetNhanVienByUser(txtTen.Text, txtMatKhau.Text);
                if(nhanVien!= null)
                {
                    ManHinhChinh manHinhChinh = new ManHinhChinh();
                    manHinhChinh.Show();
                    //Close();
                }           
            }
            catch (Exception)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
        }
    }
}
