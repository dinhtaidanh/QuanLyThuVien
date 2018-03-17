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
    
    }
}
