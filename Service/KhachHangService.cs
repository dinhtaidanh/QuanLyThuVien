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
                return qLTV.KhachHangs.Remove(rs);
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
            return qLTV.KhachHangs.Add(model);
        }

        public KhachHang UpdateKhachHang(KhachHang model)
        {
            var rs = GetKhachHangById(model.MaKhachHang);
            if (rs != null)
            {
                qLTV.SaveChanges();
                return rs;
            }
            return null;
        }
    }
}
