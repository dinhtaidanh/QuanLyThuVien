using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManHinhChinh.Model;

namespace ManHinhChinh.Interface
{
    public interface INhanVien
    {
        List<NhanVien> GetNhanVien();
        NhanVien GetNhanVienByUser(string ten, string matkhau);
        NhanVien InsertNhanVien(NhanVien model);
        NhanVien DeleteNhanVien(NhanVien model);
        NhanVien UpdateNhanVien(NhanVien model);
    }
}
