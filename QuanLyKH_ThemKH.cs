using ManHinhChinh.Service;
using System;
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

        //private void btnThemKH_Them_Click(object sender, EventArgs e)
        //{
        //    KhachHang kh = new KhachHang();
        //    kh.Ho = txtHo_Them.Text;
        //    kh.Ten = txtTen_Them.Text;
        //    kh.Email = txtEmail_Them.Text;
        //    kh.DiaChi = txtDiaChi_Them.Text;
        //    kh.SoDienThoai = txtSDT_Them.Text;
        //    KhachHangService khs = new KhachHangService();
        //    try
        //    {
        //        khs.InsertKhachHang(kh);
        //        MessageBox.Show("Thêm khách hàng thành công!");
        //        this.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Thêm khách hàng thất bại!");
        //        this.Close();
        //    }
        //}
    }
}
