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
    public partial class QuanLySach : Form
    {
        SachService sachService;
        public QuanLySach()
        {
            InitializeComponent();
            sachService  = new SachService();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLySach_ThemSach f = new QuanLySach_ThemSach();
            f.ShowDialog();
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            try
            {
                List<Sach> lst = sachService.GetSach();
                foreach (Sach item in lst)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.SubItems.Add(item.MaSach.ToString());
                    listViewItem.SubItems.Add(item.TenSach);
                    listViewItem.SubItems.Add(item.TheLoai);
                    listViewItem.SubItems.Add(item.TacGia);
                    listViewItem.SubItems.Add(item.NhaXuanBan);
                    listViewItem.SubItems.Add(item.SoLuong.ToString());                  
                    lvwDanhSach_Sach.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            try
            {

                List<Sach> lst = sachService.GetSachByTen(txtTimKiemSach.Text);
                foreach (Sach item in lst)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.SubItems.Add(item.MaSach.ToString());
                    listViewItem.SubItems.Add(item.TenSach);
                    listViewItem.SubItems.Add(item.SoLuong.ToString());
                    listViewItem.SubItems.Add(item.TacGia.ToString());
                    listViewItem.SubItems.Add(item.TheLoai.ToString());
                    lvwDanhSach_Sach.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            if (lvwDanhSach_Sach.SelectedItems.Count != 0)
            {

                ListView.SelectedListViewItemCollection collection = lvwDanhSach_Sach.SelectedItems;
                Sach sach = new Sach();
                foreach (ListViewItem item in collection)
                {
                    sach.MaSach = Convert.ToInt32(item.SubItems[1].Text);
                    sach.TenSach = item.SubItems[2].Text;
                    sach.TheLoai = item.SubItems[3].Text;
                    sach.TacGia = item.SubItems[4].Text;
                    sach.NhaXuanBan = item.SubItems[5].Text;
                    sach.SoLuong = item.SubItems[6].Text;
                }
                QuanLySach_SuaSach f = new QuanLySach_SuaSach(sach.MaSach, sach.TenSach, sach.TheLoai, sach.TacGia, sach.NhaXuanBan, sach.SoLuong);
                f.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection collection = lvwDanhSach_Sach.SelectedItems;
            foreach (ListViewItem item in collection)
            {
                Sach sach = new Sach();
                sach.MaSach = Convert.ToInt32(item.SubItems[1].Text);
                try
                {
                    sachService.DeleteSach(sach.MaSach);
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
            try
            {
                lvwDanhSach_Sach.Items.Clear();
                SachService s = new SachService();
                List<Sach> lst = s.GetSach();
                foreach (Sach item in lst)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.SubItems.Add(item.MaSach.ToString());
                    listViewItem.SubItems.Add(item.TenSach);
                    listViewItem.SubItems.Add(item.TheLoai);
                    listViewItem.SubItems.Add(item.TacGia);
                    listViewItem.SubItems.Add(item.NhaXuanBan);
                    listViewItem.SubItems.Add(item.SoLuong.ToString());
                    lvwDanhSach_Sach.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
