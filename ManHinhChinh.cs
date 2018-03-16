using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ManHinhChinh
{
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\ThuVien.mdb";
            string queryString = "SELECT * FROM Sach";
            OleDbConnection connection = new OleDbConnection(connectionString) ;   //tạo lớp kết nối vào .mbd
            using (OleDbCommand command = new OleDbCommand(queryString, connection))    //tạo lớp lệnh sql sử dụng lớp kết nối trên
            {
                try
                {
                    connection.Open();  //bắt đầu kết nối
                    OleDbDataReader reader = command.ExecuteReader();  //thực thi sql và trả về kết quả

                    while (reader.Read())  //đọc kết quả
                    {
                        Sach sach = new Sach();
                        sach.MaSach=Convert.ToInt32(reader[0]);
                        sach.TenSach = reader[1].ToString();
                        sach.SoLuong = Convert.ToInt32(reader[5]);
                        ListViewItem item = new ListViewItem();
                        item.SubItems.Add(sach.MaSach.ToString());
                        item.SubItems.Add(sach.TenSach);
                        item.SubItems.Add(sach.SoLuong.ToString());
                        lvwDanhSach.Items.Add(item);
                    }
                    reader.Close();
                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
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
