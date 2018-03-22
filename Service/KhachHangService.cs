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
                KhachHang khachHang= qLTV.KhachHangs.Remove(rs);
                qLTV.SaveChanges();
                return khachHang;
            }
            return null;
        }

        public List<KhachHang> GetKhachHang()
        {
            return qLTV.KhachHangs.ToList();
        }

        public KhachHang GetKhachHangById(int makhachhang)
        {
            var k = qLTV.KhachHangs.FirstOrDefault(x => x.MaKhachHang == makhachhang);
            if (k != null)
            {
                return k;
            }
            return null;
        }

        public List<KhachHang> GetKhachHangByName(string tenkhachhang)
        {
            return qLTV.KhachHangs.Where(x => x.Ten.Contains(tenkhachhang)).ToList();
        }

        public KhachHang InsertKhachHang(KhachHang model)
        {
            if (string.IsNullOrEmpty(model.Ho)||string.IsNullOrEmpty(model.Ten) || string.IsNullOrEmpty(model.SoDienThoai)||string.IsNullOrEmpty(model.DiaChi))
            {
                return null;
            }
            var khachhang= qLTV.KhachHangs.Add(model);
            qLTV.SaveChanges();
            return khachhang;
        }

        public KhachHang UpdateKhachHang(KhachHang model)
        {
            if (string.IsNullOrEmpty(model.Ho) || string.IsNullOrEmpty(model.Ten) || string.IsNullOrEmpty(model.SoDienThoai) || string.IsNullOrEmpty(model.DiaChi))
            {
                return null;
            }
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
