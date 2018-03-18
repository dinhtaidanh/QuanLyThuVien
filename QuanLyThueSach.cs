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
    public partial class QuanLyThueSach : Form
    {
        Sach sach;
        KhachHang kh;
        public QuanLyThueSach()
        {
            InitializeComponent();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabmuon_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyThueSach_Load(object sender, EventArgs e)
        {
            try
            {

                SachService sachService = new SachService();
                List<ThueSach> lst = sachService.GetThueSach();
                foreach (ThueSach item in lst)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.SubItems.Add(item.MaSach.ToString());
                    listViewItem.SubItems.Add(item.MaKhachHang.ToString());
                    listViewItem.SubItems.Add(item.MaSach.ToString());
                    listViewItem.SubItems.Add(item.NgayThue.ToString());
                    listViewItem.SubItems.Add(item.NgayTra.ToString());
                    listViewItem.SubItems.Add(item.TinhTrang.Equals("1") ? "Chưa trả" : "Đã trả");
                    lvwDanhSach.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cbbMaDG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTimMaSach_Click(object sender, EventArgs e)
        {
            SachService sachService = new SachService();
            try
            {
                sach = sachService.GetSachById(Convert.ToInt32(txtMaSach.Text));
                txtMaSachTim.Text = sach.MaSach.ToString();
                txtTenSach.Text = sach.TenSach;
                txtTheLoai.Text = sach.TheLoai;
                txtTacGia.Text = sach.TacGia;
                txtNhaXuatBan.Text = sach.NhaXuanBan;
                txtSL.Text = sach.SoLuong;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }

        private void btnTimMaKhachHang_Click(object sender, EventArgs e)
        {
            KhachHangService khs = new KhachHangService();
            try
            {
                kh = khs.GetKhachHangById(Convert.ToInt32(txtMaKhachHang.Text));
                txtTenKhachHang.Text = kh.Ho + " " + kh.Ten;
                txtEmail.Text = kh.Email;
                txtSoDienThoai.Text = kh.SoDienThoai;
                txtDiaChi.Text = kh.DiaChi;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }

        private void btnChoMuon_Click(object sender, EventArgs e)
        {
            SachService sachService = new SachService();
            if (Convert.ToInt32(sach.SoLuong) > 0)
            {
                try
                {
                    ThueSach thuesach = new ThueSach();
                    thuesach.MaSach = sach.MaSach;
                    thuesach.MaKhachHang = kh.MaKhachHang;
                    thuesach.NgayThue = DateTime.Now.Date;
                    thuesach.NgayTra = dtNgayHenTra.Value.Date;
                    thuesach.TinhTrang = "1";
                    sachService.ChoThueSach(thuesach);

                    sach.SoLuong = (Convert.ToInt32(sach.SoLuong) - 1).ToString();
                    sachService.UpdateSach(sach);
                    lvwDanhSach.Items.Clear();
                    List<ThueSach> lst = sachService.GetThueSach();
                    foreach (ThueSach item in lst)
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.SubItems.Add(item.MaKhachHang.ToString());
                        listViewItem.SubItems.Add(item.MaSach.ToString());
                        listViewItem.SubItems.Add(item.NgayThue.ToString());
                        listViewItem.SubItems.Add(item.NgayTra.ToString());
                        listViewItem.SubItems.Add(item.TinhTrang.ToString());
                        lvwDanhSach.Items.Add(listViewItem);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thế cho thuê!");
                }
            }
        }
    
    }
}
