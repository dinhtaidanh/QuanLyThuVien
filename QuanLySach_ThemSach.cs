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
            sach.TenSach = txtTenSach_ThemSach.Text;
            sach.TheLoai = txtTheLoai_ThemSach.Text;
            sach.TacGia = txtTacGia_ThemSach.Text;
            sach.NhaXuanBan = txtNXB_ThemSach.Text;
            sach.SoLuong = txtSoLuong_ThemSach.Text;
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
    }
}
