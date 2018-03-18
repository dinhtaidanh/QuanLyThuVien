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

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

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
