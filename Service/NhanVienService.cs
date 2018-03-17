using ManHinhChinh.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManHinhChinh.Service
{
    class NhanVienService: INhanVien
    {
        QLTVEntities qLTV = new QLTVEntities();

        public NhanVien DeleteNhanVien(NhanVien model)
        {
            var rs = qLTV.NhanViens.FirstOrDefault(x => x.MaNhanVien.Equals(model.MaNhanVien));
            if (rs != null)
            {
                return qLTV.NhanViens.Remove(rs);
            }
            return null;
        }

        public List<NhanVien> GetNhanVien()
        {
            return qLTV.NhanViens.ToList();
        }

        public NhanVien GetNhanVienByUser(string ten, string matkhau)
        {
            return qLTV.NhanViens.FirstOrDefault(x => x.TenTaiKhoan.Equals(ten) && x.MatKhau.Equals(matkhau));
        }

        public NhanVien InsertNhanVien(NhanVien model)
        {
            return qLTV.NhanViens.Add(model);
        }

        public NhanVien UpdateNhanVien(NhanVien model)
        {
            var rs = qLTV.NhanViens.FirstOrDefault(x => x.MaNhanVien.Equals(model.MaNhanVien));
            if (rs != null)
            {
                qLTV.SaveChanges();
                return rs;
            }
            return null;
        }
    }
}
