﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}