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
        int InsertKhachHang(KhachHang model);
        KhachHang DeleteKhachHang(KhachHang model);
        KhachHang UpdateKhachHang(KhachHang model);
    }
}
