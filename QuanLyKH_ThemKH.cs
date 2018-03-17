using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ManHinhChinh.Service;
namespace ManHinhChinh
{
    public partial class QuanLyKH_ThemKH : Form
    {
        public QuanLyKH_ThemKH()
        {
            InitializeComponent();
        }

        private void btnThemKH_Them_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKhachHang = 4;
            kh.Ho = txtHo_Them.Text;
            kh.Ten = txtTen_Them.Text;
            kh.Email = txtEmail_Them.Text;
            kh.DiaChi = txtDiaChi_Them.Text;
            kh.SoDienThoai = txtSDT_Them.Text;
            KhachHangService khs = new KhachHangService();
            //try
            //{
                khs.InsertKhachHang(kh);
                MessageBox.Show("Thêm khách hàng thành công!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Thêm khách hàng thất bại!");
            //}
        }
    }
}
