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
    public class UnitTestThueSach
    {
        SachService sachService;
        [TestInitialize]
        public void SetUp()
        {
            sachService = new SachService();
        }
        [TestMethod]
        public void TestGetThueSachKhach()
        {
            int makhachhang = 1;
            int masach = 2;
            var k = sachService.GetThueSachKhach(makhachhang, masach);
            Assert.IsNotNull(k);
        }
        [TestMethod]
        public void TestGetThueSachKhachKhongDB()
        {
            int makhachhang = 1;
            int masach = 123;
            var k = sachService.GetThueSachKhach(makhachhang, masach);
            Assert.IsNull(k);
        }
        [TestMethod]
        public void TestGetThueSachById()
        {
            int makhachhang = 1;
            var k = sachService.GetThueSachById(makhachhang);
            Assert.IsNotNull(k);
        }
        [TestMethod]
        public void TestGetThueSachByIdKhongDB()
        {
            int makhachhang = 123;
            var k = sachService.GetThueSachById(makhachhang);
            Assert.IsNull(k);
        }
        [TestMethod]
        public void TestChoThueSach()
        {
            ThueSach thueSach = new ThueSach()
            {
                MaKhachHang = 1,
                MaSach = 1,
                NgayTra = DateTime.Now,
            };
            var k = sachService.ChoThueSach(thueSach);
            Assert.IsNotNull(k);
        }
        [TestMethod]
        public void TestChoThueSachKhongDB()
        {
            ThueSach thueSach = new ThueSach()
            {
                MaKhachHang = 123,
                MaSach = 1,
                NgayTra = DateTime.Now,
            };
            var k = sachService.ChoThueSach(thueSach);
            Assert.IsNull(k);
        }
        [TestMethod]
        public void TestTraSach()
        {
            int makhachhang = 1;
            int masach = 1;
            var k = sachService.TraSach(makhachhang, masach);
            Assert.IsNotNull(k);
        }
        [TestMethod]
        public void TestTraSachKhongDB()
        {
            int makhachhang = 123;
            int masach = 1;
            var k = sachService.TraSach(makhachhang, masach);
            Assert.IsNull(k);
        }
    }
}
