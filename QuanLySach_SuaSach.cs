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
    public partial class QuanLySach_SuaSach : Form
    {
        Sach sach = new Sach();
        public QuanLySach_SuaSach(int MaSach, string TenSach, string TheLoai, string TacGia, string NXB, string SoLuong)
        {
            InitializeComponent();
            sach.MaSach = MaSach;
            txtTenSach_SuaSach.Text = TenSach;
            txtTheLoai_SuaSach.Text = TheLoai;
            txtTacGia_SuaSach.Text = TacGia;
            txtNXB_SuaSach.Text = NXB;
            txtSoLuong_SuaSach.Text = SoLuong;
        }

        private void btnNull_TatCa_SuaSach_Click(object sender, EventArgs e)
        {
            txtTenSach_SuaSach.Clear();
            txtTheLoai_SuaSach.Clear();
            txtTacGia_SuaSach.Clear();
            txtNXB_SuaSach.Clear();
            txtSoLuong_SuaSach.Clear();
        }

        private void btnNull_MaSach_SuaSach_Click(object sender, EventArgs e)
        {
        }

        private void btnNull_TenSach_SuaSach_Click(object sender, EventArgs e)
        {
            txtTenSach_SuaSach.Clear();
        }

        private void btnNull_TheLoai_SuaSach_Click(object sender, EventArgs e)
        {
            txtTheLoai_SuaSach.Clear();
        }

        private void btnNull_TacGia_SuaSach_Click(object sender, EventArgs e)
        {
            txtTacGia_SuaSach.Clear();
        }

        private void btnNull_NXB_SuaSach_Click(object sender, EventArgs e)
        {
            txtNXB_SuaSach.Clear();
        }

        private void btnNull_SoLuong_SuaSach_Click(object sender, EventArgs e)
        {
            txtSoLuong_SuaSach.Clear();
        }

        private void btnSuaSach_SuaSach_Click(object sender, EventArgs e)
        {      
            SachService s = new SachService();
            sach.TenSach = txtTenSach_SuaSach.Text.Trim();
            sach.TheLoai = txtTheLoai_SuaSach.Text.Trim();
            sach.TacGia = txtTacGia_SuaSach.Text.Trim();
            sach.NhaXuanBan = txtNXB_SuaSach.Text.Trim();
            sach.SoLuong = txtSoLuong_SuaSach.Text.Trim();
            try
            {
                s.UpdateSach(sach);
                MessageBox.Show("Sửa thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại!");
                this.Close();
            }
        }
    }
}
