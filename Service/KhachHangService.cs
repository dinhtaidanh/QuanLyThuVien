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
        QLTVEntities qLTV = new QLTVEntities();

        public KhachHang DeleteKhachHang(int makhachhang)
        {
            var rs = GetKhachHangById(makhachhang);
            if (rs != null)
            {              
                qLTV.KhachHangs.Remove(rs);
                qLTV.SaveChanges();
            }
            return null;
        }

        public List<KhachHang> GetKhachHang()
        {
            return qLTV.KhachHangs.ToList();
        }

        public KhachHang GetKhachHangById(int makhachhang)
        {
            return qLTV.KhachHangs.FirstOrDefault(x => x.MaKhachHang == makhachhang);
        }

        public List<KhachHang> GetKhachHangByName(string tenkhachhang)
        {
            return qLTV.KhachHangs.Where(x => x.Ten.Contains(tenkhachhang)).ToList();
        }

        public KhachHang InsertKhachHang(KhachHang model)
        {
            qLTV.KhachHangs.Add(model);
            qLTV.SaveChanges();
            return null;
        }

        public KhachHang UpdateKhachHang(KhachHang model)
        {
            var rs = GetKhachHangById(model.MaKhachHang);
            if (rs != null)
            {
                rs.Ho = model.Ho ;
                rs.Ten = model.Ten ; 
                rs.Email = model.Email ;
                rs.DiaChi = model.DiaChi ;
                rs.SoDienThoai = model.SoDienThoai;
                qLTV.SaveChanges();
                return rs;
            }
            return null;
        }
    }
}
