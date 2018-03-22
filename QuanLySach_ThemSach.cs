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
    public partial class QuanLySach_ThemSach : Form
    {
        public QuanLySach_ThemSach()
        {
            InitializeComponent();
        }

        private void btnThemSach_ThemSach_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.TenSach = txtTenSach_ThemSach.Text.Trim();
            sach.TheLoai = txtTheLoai_ThemSach.Text.Trim();
            sach.TacGia = txtTacGia_ThemSach.Text.Trim();
            sach.NhaXuanBan = txtNXB_ThemSach.Text.Trim();
            sach.SoLuong = txtSoLuong_ThemSach.Text.Trim();
            SachService s = new SachService();
            try
            {
                s.InsertSach(sach);
                MessageBox.Show("Thêm thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại!");
                this.Close();
            }
        }

        private void txtSoLuong_ThemSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
