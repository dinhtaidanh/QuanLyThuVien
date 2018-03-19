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
            khachHangService = new KhachHangService();
        }
        [TestMethod]
        public void TestInsertKhachHang()
        {
            KhachHang khachHang = new KhachHang()
            {
                Ho = "abc",
                Ten = "abc",
                DiaChi = "abc",
                Email = "abc",
                SoDienThoai = "abc"
            };
            var k= khachHangService.InsertKhachHang(khachHang);
            Assert.IsNotNull(k);
        }
        [TestMethod]
        public void TestInsertKhachHangKhongGiaTri()
        {
            KhachHang khachHang = new KhachHang()
            {
                Ho = "",
                Ten = "",
                DiaChi = "",
                Email = "",
                SoDienThoai = ""
            };
            var k = khachHangService.InsertKhachHang(khachHang);
            Assert.IsNull(k);
        }
        [TestMethod]
        public void TestInsertKhachHangKhongPhone()
        {
            KhachHang khachHang = new KhachHang()
            {
                Ho = "abc",
                Ten = "abc",
                DiaChi = "abc",
            };
            var k = khachHangService.InsertKhachHang(khachHang);
            Assert.IsNull(k);
        }
        [TestMethod]
        public void TestUpdateKhachHangTrongDB()
        {
            KhachHang khachHang = new KhachHang()
            {
                MaKhachHang = 1,
                Ho = "abc",
                Ten = "abc",
                DiaChi = "abc",
                Email = "abc",
                SoDienThoai = "abc"
            };
            var k = khachHangService.UpdateKhachHang(khachHang);
            Assert.IsNotNull(k);
        }
        [TestMethod]
        public void TestUpdateKhachHangKhongDB()
        {
            KhachHang khachHang = new KhachHang()
            {
                MaKhachHang = 123,
                Ho = "abc",
                Ten = "abc",
                DiaChi = "abc",
                Email = "abc",
                SoDienThoai = "abc"
            };
            var k = khachHangService.UpdateKhachHang(khachHang);
            Assert.IsNull(k);
        }
        [TestMethod]
        public void TestUpdateKhachHangTrongDBKhongGiaTri()
        {
            KhachHang khachHang = new KhachHang()
            {
                MaKhachHang = 1,
                Ho = "",
                Ten = "",
                DiaChi = "",
                Email = "",
                SoDienThoai = ""
            };
            var k = khachHangService.UpdateKhachHang(khachHang);
            Assert.IsNull(k);
        }
        [TestMethod]
        public void TestDeleteKhachHangTrongDB()
        {
            var k = khachHangService.DeleteKhachHang(1);
            Assert.IsNotNull(k);
        }
        [TestMethod]
        public void TestDeleteKhachHangKhongDB()
        {
            var k = khachHangService.DeleteKhachHang(123);
            Assert.IsNull(k);
        }
        [TestMethod]
        public void TestGetKhachHangById()
        {
            var k = khachHangService.GetKhachHangById(1);
            Assert.IsNotNull(k);
        }
        [TestMethod]
        public void TestGetKhachHangByIdKhac()
        {
            var k = khachHangService.GetKhachHangById(123);
            Assert.IsNull(k);
        }

    }
}
