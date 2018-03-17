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
    public partial class QuanLySach_SuaSach : Form
    {
        public QuanLySach_SuaSach()
        {
            InitializeComponent();
        }

        private void btnNull_TatCa_SuaSach_Click(object sender, EventArgs e)
        {
            txtMaSach_SuaSach.Clear();
            txtTenSach_SuaSach.Clear();
            txtTheLoai_SuaSach.Clear();
            txtTacGia_SuaSach.Clear();
            txtNXB_SuaSach.Clear();
            txtSoLuong_SuaSach.Clear();
        }

        private void btnNull_MaSach_SuaSach_Click(object sender, EventArgs e)
        {
            txtMaSach_SuaSach.Clear();
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
    }
}
