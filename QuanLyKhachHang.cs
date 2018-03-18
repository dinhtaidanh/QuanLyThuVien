using ManHinhChinh.Model;
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
    public partial class QuanLyKhachHang : Form
    {
        KhachHangService khachHangService = new KhachHangService();
        public QuanLyKhachHang()
        {
            InitializeComponent();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                List<KhachHang> lst=khachHangService.GetKhachHang();
                foreach(KhachHang k in lst)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(k.MaKhachHang.ToString());
                    item.SubItems.Add(k.Ho);
                    item.SubItems.Add(k.Ten);
                    item.SubItems.Add(k.Email);
                    item.SubItems.Add(k.DiaChi);
                    item.SubItems.Add(k.SoDienThoai);
                    lvwDanhSachKH.Items.Add(item);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            lvwDanhSachKH.Items.Clear();
            try
            {
                List<KhachHang> lst = khachHangService.GetKhachHangByName(txtTimKiemKH.Text);
                foreach (KhachHang k in lst)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(k.MaKhachHang.ToString());
                    item.SubItems.Add(k.Ho);
                    item.SubItems.Add(k.Ten);
                    item.SubItems.Add(k.Email);
                    item.SubItems.Add(k.DiaChi);
                    item.SubItems.Add(k.SoDienThoai);
                    lvwDanhSachKH.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLyKH_ThemKH quanLyKH_ThemKH = new QuanLyKH_ThemKH();
            quanLyKH_ThemKH.Show();
        }

        private void lvwDanhSachKH_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvwDanhSachKH.SelectedItems.Count != 0)
            {
                
                ListView.SelectedListViewItemCollection collection = lvwDanhSachKH.SelectedItems;
                KhachHang kh = new KhachHang();
                foreach (ListViewItem item in collection)
                {                 
                    kh.MaKhachHang = Convert.ToInt32(item.SubItems[1].Text);
                    kh.Ho = item.SubItems[2].Text;
                    kh.Ten = item.SubItems[3].Text;
                    kh.Email = item.SubItems[4].Text;
                    kh.DiaChi = item.SubItems[5].Text;
                    kh.SoDienThoai = item.SubItems[6].Text;
                }
                QuanLyKH_SuaKH f = new QuanLyKH_SuaKH(kh.MaKhachHang, kh.Ho,kh.Ten,kh.Email,kh.DiaChi,kh.SoDienThoai);
                f.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection collection = lvwDanhSachKH.SelectedItems;
            foreach (ListViewItem item in collection)
            {
                KhachHang kh = new KhachHang();
                kh.MaKhachHang = Convert.ToInt32(item.SubItems[1].Text);
                try
                {
                    khachHangService.DeleteKhachHang(kh.MaKhachHang);
                    MessageBox.Show("Xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lvwDanhSachKH.Items.Clear();
            try
            {
                KhachHangService s = new KhachHangService();
                List<KhachHang> lst = s.GetKhachHang();
                foreach (KhachHang k in lst)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(k.MaKhachHang.ToString());
                    item.SubItems.Add(k.Ho);
                    item.SubItems.Add(k.Ten);
                    item.SubItems.Add(k.Email);
                    item.SubItems.Add(k.DiaChi);
                    item.SubItems.Add(k.SoDienThoai);
                    lvwDanhSachKH.Items.Add(item);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
