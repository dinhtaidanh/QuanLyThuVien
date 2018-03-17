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
    public partial class QuanLyKH_SuaKH : Form
    {
        KhachHangService khs = new KhachHangService();
        KhachHang kh = new KhachHang();
        public QuanLyKH_SuaKH(int MaKhachHang, string Ho, string Ten, string Email, string DiaChi, string SoDienThoai)
        {
            InitializeComponent();
            kh.MaKhachHang = MaKhachHang;
            txtHo_Sua.Text = Ho;
            txtTen_Sua.Text = Ten;
            txtEmail_Sua.Text = Email;
            txtDiaChi_Sua.Text = DiaChi;
            txtSDT_Sua.Text = SoDienThoai;
        }

        private void btnNull_MaKH_SuaKH_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNull_Ho_SuaKH_Click(object sender, EventArgs e)
        {
            txtHo_Sua.Clear();
        }

        private void btnNull_Ten_SuaKH_Click(object sender, EventArgs e)
        {
            txtTen_Sua.Clear();
        }

        private void btnNull_Email_SuaKH_Click(object sender, EventArgs e)
        {
            txtEmail_Sua.Clear();
        }

        private void btnNull_DiaChi_SuaKH_Click(object sender, EventArgs e)
        {
            txtDiaChi_Sua.Clear();
        }

        private void btnNull_SDT_SuaKH_Click(object sender, EventArgs e)
        {
            txtSDT_Sua.Clear();
        }

        private void btnNull_TatCa_SuaKH_Click(object sender, EventArgs e)
        {     
            txtHo_Sua.Clear();
            txtTen_Sua.Clear();
            txtEmail_Sua.Clear();
            txtDiaChi_Sua.Clear();
            txtSDT_Sua.Clear();
        }

        private void btnSuaKH_Sua_Click(object sender, EventArgs e)
        {
            try
            {              
                kh.Ho = txtHo_Sua.Text;
                kh.Ten = txtTen_Sua.Text;
                kh.Email = txtEmail_Sua.Text;
                kh.DiaChi = txtDiaChi_Sua.Text ;
                kh.SoDienThoai = txtSDT_Sua.Text;
                khs.UpdateKhachHang(kh);
                MessageBox.Show("Sửa thành công!");
            }
            catch(Exception ex){
                MessageBox.Show("Không thể sửa!");
            }
        }
    }
}
