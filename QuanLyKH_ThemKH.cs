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
    public partial class QuanLyKH_ThemKH : Form
    {
        KhachHangService khachHangService;
        public QuanLyKH_ThemKH()
        {
            InitializeComponent();
            khachHangService = new KhachHangService();
        }

        private void btnThemKH_Them_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang khachHang = new KhachHang()
                {
                    Ho = txtHo_Them.Text,
                    Ten = txtTen_Them.Text,
                    Email = txtEmail_Them.Text,
                    DiaChi = txtDiaChi_Them.Text,
                    SoDienThoai = txtSDT_Them.Text
                };
                khachHangService.InsertKhachHang(khachHang);
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
