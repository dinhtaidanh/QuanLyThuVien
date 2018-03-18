using System;
using System.Net.Mail;
using ManHinhChinh;
using ManHinhChinh.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestQLTV
{
    [TestClass]
    public class UnitTestKhachHang
    {
        KhachHangService khachHangService;
        [TestInitialize]
        public void SetUp()
        {
        }
        [TestMethod]
        public void TestInsertKhachHang()
        {
            khachHangService = new KhachHangService();
            KhachHang khachHang = new KhachHang()
            {
                Ho = "123",
                Ten = "123",
                DiaChi = "123",
                Email = "123",
                SoDienThoai = "123"
            };
            var k= khachHangService.InsertKhachHang(khachHang);
            Assert.IsNotNull(k);
        }
    }
}
