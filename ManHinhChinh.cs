using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using ManHinhChinh.Model;
using ManHinhChinh.Service;

namespace ManHinhChinh
{
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void btnQuanLiKH_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang f = new QuanLyKhachHang();
            f.ShowDialog();
        }

        private void btnQuanLiSach_Click(object sender, EventArgs e)
        {
            QuanLySach f = new QuanLySach();
            f.ShowDialog();
        }

        private void btnQuanLiThueSach_Click(object sender, EventArgs e)
        {
            QuanLyThueSach f = new QuanLyThueSach();
            f.ShowDialog();
        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            TraCuuSach f = new TraCuuSach();
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }
        private void menuTrip_QLS(object sender, EventArgs e)
        {
            QuanLySach f = new QuanLySach();
            f.ShowDialog();
        }

        private void menuTrip_QLTS(object sender, EventArgs e)
        {
            QuanLyThueSach f = new QuanLyThueSach();
            f.ShowDialog();
        }

        private void menuTrip_Thoat(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuTrip_QLKH(object sender, EventArgs e)
        {
            QuanLyKhachHang f = new QuanLyKhachHang();
            f.ShowDialog();
        }

        private void lvwDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection collection = lvwDanhSach.SelectedItems;
            foreach (ListViewItem item in collection)
            {
                txtMaSach.Text = item.SubItems[1].Text;
                txtTenSach.Text = item.SubItems[2].Text;
                txtTheLoai.Text = item.SubItems[5].Text; 
                txtTacGia.Text = item.SubItems[4].Text;
                txtSoLuong.Text = item.SubItems[3].Text;
                
            }

        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            lvwDanhSach.MultiSelect = false;
            try
            {

                SachService sachService = new SachService();
                List<Sach> lst = sachService.GetSach();
                foreach (Sach item in lst)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.SubItems.Add(item.MaSach.ToString());
                    listViewItem.SubItems.Add(item.TenSach);
                    listViewItem.SubItems.Add(item.SoLuong.ToString());
                    listViewItem.SubItems.Add(item.TacGia.ToString());
                    listViewItem.SubItems.Add(item.TheLoai.ToString());
                    lvwDanhSach.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
