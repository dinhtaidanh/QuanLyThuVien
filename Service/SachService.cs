using ManHinhChinh.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ManHinhChinh.Service
{
    public class SachService : ISach
    {
        QLTVEntities qLTV = new QLTVEntities();

        public Sach DeleteSach(int masach)
        {
            var rs = GetSachById(masach);
            if (rs != null)
            {
                qLTV.Saches.Remove(rs);
                qLTV.SaveChanges();
            }
            return null;
        }

        public List<Sach> GetSach()
        {
            return qLTV.Saches.ToList();
        }

        public Sach GetSachById(int masach)
        {
            return qLTV.Saches.FirstOrDefault(x => x.MaSach == masach);
        }

        public List<Sach> GetSachByTen(string ten)
        {
            return qLTV.Saches.Where(x => x.TenSach.Contains(ten)).ToList();
        }

        public List<Sach> GetSachByTheLoai(string theloai)
        {
            return qLTV.Saches.Where(x => x.TheLoai.Equals(theloai)).ToList();
        }

        public ThueSach GetThueSachKhach(int makhachhang, int masach)
        {
            return qLTV.ThueSaches.FirstOrDefault(x => x.MaKhachHang == makhachhang && x.MaSach == masach);
        }

        public List<ThueSach> GetThueSachById(int makhachhang)
        {
            return qLTV.ThueSaches.Where(x => x.MaKhachHang == makhachhang && x.TinhTrang.Equals("1")).ToList();
        }

        public Sach InsertSach(Sach model)
        {
            qLTV.Saches.Add(model);
            qLTV.SaveChanges();
            return null;
        }

        public Sach ChoThueSach(ThueSach model)
        {                               
            qLTV.ThueSaches.Add(model);
            qLTV.SaveChanges();
            return null;
        }

        public ThueSach TraSach(int makhachhang, int masach)
        {
            if (GetSachById(masach) != null)
            {
                KhachHangService khachHangService = new KhachHangService();
                if (khachHangService.GetKhachHangById(makhachhang) != null)
                {
                    ThueSach thueSach = GetThueSachKhach(makhachhang, masach);
                    if (thueSach != null)
                    {
                        thueSach.TinhTrang = "0";
                        qLTV.SaveChanges();
                        return thueSach;
                    };
                    return null;
                }
                return null;
            }
            return null;
        }

        public Sach UpdateSach(Sach model)
        {
            var rs = qLTV.Saches.FirstOrDefault(x => x.MaSach.Equals(model.MaSach));
            if (rs != null)
            {
                rs.TenSach = model.TenSach;
                rs.TheLoai = model.TheLoai;
                rs.TacGia = model.TacGia;
                rs.NhaXuanBan = model.NhaXuanBan;
                rs.SoLuong = model.SoLuong;
                qLTV.SaveChanges();
                return rs;
            }
            return null;
        }

        public List<ThueSach> GetThueSach()
        {
            return qLTV.ThueSaches.ToList();
        }
        
    }
}
