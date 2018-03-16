using ManHinhChinh.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManHinhChinh.Interface
{
    public interface ISach
    {
        List<string> GetLoaiSach();
        List<Sach> GetSach();
        Sach InsertSach(Sach model);
        Sach DeleteSach(Sach model);
        Sach UpdateSach(Sach model);
        List<Sach> GetSachByTheLoai(string theloai);
        List<Sach> GetSachByTen(string ten);
    }
}
