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
                List<ThueSach> lstChuaTra = sachService.GetThueSachChuaTra();
                foreach (ThueSach item in lstChuaTra)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.SubItems.Add(item.MaKhachHang.ToString());
                    listViewItem.SubItems.Add(item.MaSach.ToString());                  
                    listViewItem.SubItems.Add(item.NgayThue.ToString());
                    listViewItem.SubItems.Add(item.NgayTra.ToString());
                    listViewItem.SubItems.Add(item.TinhTrang.Equals("1") ? "Chưa trả" : "Đã trả");
                    lvwDanhSach.Items.Add(listViewItem);
                }
                List<ThueSach> lstDaTra = sachService.GetThueSachDaTra();
                foreach (ThueSach thuesach in lstDaTra)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(thuesach.MaKhachHang.ToString());
                    item.SubItems.Add(thuesach.MaSach.ToString());
                    item.SubItems.Add(thuesach.NgayThue.ToShortDateString());
                    item.SubItems.Add(thuesach.NgayTra.ToShortDateString());
                    item.SubItems.Add(thuesach.TinhTrang.Equals("1") ? "Chưa trả" : "Đã trả");
                    lvwDanhSachTra.Items.Add(item);
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
            if (!string.IsNullOrEmpty(txtMaSachTim.Text) && !string.IsNullOrEmpty(txtTenKhachHang.Text)) {
                SachService sachService = new SachService();
                sach = sachService.GetSachById(Convert.ToInt32(txtMaSachTim.Text));
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
                        List<ThueSach> lst = sachService.GetThueSachChuaTra();
                        foreach (ThueSach item in lst)
                        {
                            ListViewItem listViewItem = new ListViewItem();
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
                        MessageBox.Show("Không thế cho thuê!");
                    }
                }
            }
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            SachService s = new SachService();
            int MaKH = Convert.ToInt32(txtMaKH_TraSach.Text);
            int MaSach = Convert.ToInt32(txtMaSach_TraSach.Text);
            try
            {
                s.TraSach(MaKH, MaSach);
                MessageBox.Show("Trả sách thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi trả sách");
            }
            List<ThueSach> lstDaTra = s.GetThueSachDaTra();
            lvwDanhSachTra.Items.Clear();
            foreach (ThueSach thuesach in lstDaTra)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(thuesach.MaKhachHang.ToString());
                item.SubItems.Add(thuesach.MaSach.ToString());
                item.SubItems.Add(thuesach.NgayThue.ToShortDateString());
                item.SubItems.Add(thuesach.NgayTra.ToShortDateString());
                item.SubItems.Add(thuesach.TinhTrang.Equals("1") ? "Chưa trả" : "Đã trả");
                lvwDanhSachTra.Items.Add(item);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSachTim_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTheLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTacGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNhaXuatBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btnTimSach_Tra_Click(object sender, EventArgs e)
        {
            SachService sachService = new SachService();
            try
            {
                Sach s = new Sach();
                s = sachService.GetSachById(Convert.ToInt32(txtMaSach_TraSach.Text));                
                txtTenSach_Tra.Text = s.TenSach;
                txtTheLoai_Tra.Text = s.TheLoai;
                txtTacGia_Tra.Text = s.TacGia;
                txtNhaXuatBan_Tra.Text = s.NhaXuanBan;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }

        private void btnTimKH_Tra_Click(object sender, EventArgs e)
        {
            KhachHangService khs = new KhachHangService();
            try
            {
                KhachHang k = new KhachHang();
                k = khs.GetKhachHangById(Convert.ToInt32(txtMaKH_TraSach.Text));
                txtTen_Tra.Text = k.Ho + " " + k.Ten;
                txtEmail_Tra.Text = k.Email;
                txtSDT_Tra.Text = k.SoDienThoai;
                txtDiaChi_Tra.Text = k.DiaChi;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }
    }
}
