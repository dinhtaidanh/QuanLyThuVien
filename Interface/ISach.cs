using ManHinhChinh.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManHinhChinh.Interface
{
    public interface ISach
    {
        List<Sach> GetSach();
        Sach InsertSach(Sach model);
        Sach DeleteSach(int masach);
        Sach UpdateSach(Sach model);
        List<Sach> GetSachByTheLoai(string theloai);
        List<Sach> GetSachByTen(string ten);
        Sach GetSachById(int masach);
        ThueSach MuonSach(int makhachhang, int masach, DateTime ngaytra);
        ThueSach TraSach(int makhachhang, int masach);
        ThueSach GetThueSachKhach(int makhachhang, int masach);
        List<ThueSach> GetThueSachById(int makhachhang);
        List<ThueSach> GetThueSach();
    }
}
