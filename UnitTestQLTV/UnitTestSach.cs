using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManHinhChinh;
using ManHinhChinh.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestQLTV
{
    [TestClass]
    public class UnitTestSach
    {
        SachService sachService ;
        [TestInitialize]
        public void SetUp()
        {
            sachService = new SachService();
        }
        [TestMethod]
        public void TestInsertSach()
        {
            Sach sach = new Sach()
            {
                TenSach = "abc",
                TacGia = "abc",
                TheLoai = "abc",
                NhaXuanBan = "abc",
                SoLuong = "abc"
            };
            var k = sachService.InsertSach(sach);
            Assert.IsNotNull(k);
        }
        [TestMethod]
        public void TestInsertSachKhongGiaTri()
        {
            Sach sach = new Sach()
            {
                TenSach = "",
                TacGia = "",
                TheLoai = "",
                NhaXuanBan = "",
                SoLuong = ""
            };
            var k = sachService.InsertSach(sach);
            Assert.IsNull(k);
        }
        [TestMethod]
        public void TestInsertSachKhongTenSach()
        {
            Sach sach = new Sach()
            {
                TacGia = "",
                TheLoai = "",
                NhaXuanBan = "",
                SoLuong = ""
            };
            var k = sachService.InsertSach(sach);
            Assert.IsNull(k);
        }
        [TestMethod]
        public void TestUpdateSach()
        {
            Sach sach = new Sach()
            {
                MaSach= 1,
                TenSach = "abc",
                TacGia = "abc",
                TheLoai = "abc",
                NhaXuanBan = "abc",
                SoLuong = "abc"
            };
            var k = sachService.UpdateSach(sach);
            Assert.IsNotNull(k);
        }
        [TestMethod]
        public void TestUpdateSachKhongDB()
        {
            Sach sach = new Sach()
            {
                MaSach = 123456789,
                TenSach = "abc",
                TacGia = "abc",
                TheLoai = "abc",
                NhaXuanBan = "abc",
                SoLuong = "abc"
            };
            var k = sachService.UpdateSach(sach);
            Assert.IsNull(k);
        }
        [TestMethod]
        public void TestUpdateTrongDBKhongGiaTri()
        {
            Sach sach = new Sach()
            {
                MaSach = 1,
                TenSach = "",
                TacGia = "",
                TheLoai = "",
                NhaXuanBan = "",
                SoLuong = ""
            };
            var k = sachService.UpdateSach(sach);
            Assert.IsNull(k);
        }
        [TestMethod]
        public void TestDeleteSachTrongDB()
        {
            var k = sachService.DeleteSach(1);
            Assert.IsNotNull(k);
        }
        [TestMethod]
        public void TestDeleteSachKhongDB()
        {
            var k = sachService.DeleteSach(123);
            Assert.IsNull(k);
        }
        [TestMethod]
        public void TestGetSachById()
        {
            var k = sachService.GetSachById(1);
            Assert.IsNotNull(k);
        }
        [TestMethod]
        public void TestGetSachByIdKhac()
        {
            var k = sachService.GetSachById(123);
            Assert.IsNull(k);
        }
    }
}
