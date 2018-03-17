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
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();;
            List<KhachHang> lstKhachHang = new List<KhachHang>();
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\ThuVien.mdb";
            string queryString = "SELECT * FROM KhachHang";
            OleDbConnection connection = new OleDbConnection(connectionString);   //tạo lớp kết nối vào .mbd
            using (OleDbCommand command = new OleDbCommand(queryString, connection))    //tạo lớp lệnh sql sử dụng lớp kết nối trên
            {
                try
                {
                    connection.Open();  //bắt đầu kết nối
                    OleDbDataReader reader = command.ExecuteReader();  //thực thi sql và trả về kết quả

                    while (reader.Read())  //đọc kết quả
                    {
                        KhachHang khachhang = new KhachHang();
                        khachhang.MaKhachHang = Convert.ToInt32(reader[0]);
                        khachhang.Ho = reader[1].ToString();
                        khachhang.Ten = reader[2].ToString();
                        khachhang.Email = reader[3].ToString();
                        khachhang.DiaChi = reader[4].ToString();
                        khachhang.SoDienThoai = reader[5].ToString();
                        lstKhachHang.Add(khachhang);

                        ListViewItem item = new ListViewItem();
                        item.SubItems.Add(khachhang.MaKhachHang.ToString());
                        item.SubItems.Add(khachhang.Ho+" "+khachhang.Ten);
                        item.SubItems.Add(khachhang.DiaChi.ToString());
                        item.SubItems.Add(khachhang.SoDienThoai.ToString());
                        item.SubItems.Add(khachhang.Email.ToString());
                        lvwDanhSachKH.Items.Add(item);
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvwDanhSachKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemKhachHang f = new ThemKhachHang();
            f.ShowDialog();
        }
    }
}
