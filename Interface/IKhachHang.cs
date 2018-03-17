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
        KhachHang InsertKhachHang(KhachHang model);
        KhachHang UpdateKhachHang(KhachHang model);
        KhachHang DeleteKhachHang(int makhachhang);
        KhachHang GetKhachHangById(int makhachhang);
    }
}
