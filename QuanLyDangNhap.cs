using ManHinhChinh.Service;
using System;
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
                NhanVien nhanVien = nhanVienService.GetNhanVienByUser(txtTen.Text.Trim(), txtMatKhau.Text.Trim());
                if(nhanVien!= null)
                {
                    ManHinhChinh manHinhChinh = new ManHinhChinh();
                    manHinhChinh.Show();
                    Hide();
                }           
            }
            catch (Exception)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
        }
    }
}
