using ManHinhChinh.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManHinhChinh.Interface
{
    public interface IKhachHang
    {
        List<KhachHang> GetKhachHang();
        void InsertKhachHang(KhachHang model);
        void UpdateKhachHang(KhachHang model);
        void DeleteKhachHang(int makhachhang);
        KhachHang GetKhachHangById(int makhachhang);
        List<KhachHang> GetKhachHangByName(string tenkhachhang);
    }
}
