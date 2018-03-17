﻿using ManHinhChinh.Model;
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
        KhachHangService khachHangService;
        public QuanLyKhachHang()
        {
            InitializeComponent();
            khachHangService = new KhachHangService();
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
            catch (Exception)
            {

                throw;
            }

        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
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
            catch (Exception)
            {

                throw;
            }
        }
    }
}
