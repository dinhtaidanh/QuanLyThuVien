using ManHinhChinh.Interface;
using ManHinhChinh.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace ManHinhChinh.Service
{
    public class KhachHangService : IKhachHang
    {
        Connection cn;
        public KhachHangService()
        {
            cn = new Connection();
            cn.openConnection();
        }
        public KhachHang DeleteKhachHang(KhachHang model)
        {
            throw new NotImplementedException();
        }

        public List<KhachHang> GetKhachHang()
        {
            string queryString = "SELECT * FROM KhachHang";
            List<KhachHang> listkhachhang = new List<KhachHang>();
            OleDbCommand command = cn.GetDbCommand(queryString);
            OleDbDataReader reader = command.ExecuteReader();  //thực thi sql và trả về kết quả
            while (reader.Read())  //đọc kết quả
            {
                KhachHang khachHang = new KhachHang();
                khachHang.MaKhachHang = reader[0].ToString();
                khachHang.Ho = reader[1].ToString();
                khachHang.Ten = reader[2].ToString();
                khachHang.Email = reader[3].ToString();
                khachHang.DiaChi = reader[4].ToString();
                khachHang.SoDienThoai = reader[5].ToString();
                listkhachhang.Add(khachHang);
            }
            return listkhachhang;
        }

        public int InsertKhachHang(KhachHang model)
        {
            string queryString = "INSERT INTO KhachHang(Ho, Ten, Email, DiaChi, SoDienThoai) " +
                   "VALUES (@Ho, @Ten, @Email, @DiaChi, @SoDienThoai) ";
            OleDbCommand command = cn.GetDbCommand(queryString);
            command.Parameters.Add("@Ho", OleDbType.Char).Value = model.Ho;
            command.Parameters.Add("@Ten", OleDbType.Char).Value = model.Ten;
            command.Parameters.Add("@Email", OleDbType.Char).Value = model.Email;
            command.Parameters.Add("@DiaChi", OleDbType.Char).Value = model.DiaChi;
            command.Parameters.Add("@SoDienThoai", OleDbType.Char).Value = model.SoDienThoai;
            return command.ExecuteNonQuery();
        }

        public KhachHang UpdateKhachHang(KhachHang model)
        {
            throw new NotImplementedException();
        }
    }
}
