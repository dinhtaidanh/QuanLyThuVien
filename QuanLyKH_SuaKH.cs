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
    public partial class QuanLyKH_SuaKH : Form
    {
        public QuanLyKH_SuaKH()
        {
            InitializeComponent();
        }

        private void btnNull_MaKH_SuaKH_Click(object sender, EventArgs e)
        {
            txtMaKH_Sua.Clear();
        }

        private void btnNull_Ho_SuaKH_Click(object sender, EventArgs e)
        {
            txtHo_Sua.Clear();
        }

        private void btnNull_Ten_SuaKH_Click(object sender, EventArgs e)
        {
            txtTen_Sua.Clear();
        }

        private void btnNull_Email_SuaKH_Click(object sender, EventArgs e)
        {
            txtEmail_Sua.Clear();
        }

        private void btnNull_DiaChi_SuaKH_Click(object sender, EventArgs e)
        {
            txtDiaChi_Sua.Clear();
        }

        private void btnNull_SDT_SuaKH_Click(object sender, EventArgs e)
        {
            txtSDT_Sua.Clear();
        }

        private void btnNull_TatCa_SuaKH_Click(object sender, EventArgs e)
        {
            txtMaKH_Sua.Clear();
            txtHo_Sua.Clear();
            txtTen_Sua.Clear();
            txtEmail_Sua.Clear();
            txtDiaChi_Sua.Clear();
            txtSDT_Sua.Clear();
        }
    }
}
