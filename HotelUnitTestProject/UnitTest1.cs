using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using HotelManagementApplication;
using System;

namespace HotelUnitTestProject
{
    [TestClass]
    public class DBUnitTest
    {
        [TestMethod]
        public void DBStaffNameTestMethod()
        {
            var mockStaff = new Mock<Staff_tbl>();    
            var staff = new Mock<IStaff>();
            staff.Setup(p => p.StaffId).Returns(1);
            staff.SetupGet(p => p.Staffname).Returns("ioana");
            Assert.AreEqual("ioana", staff.Object.Staffname);

        }

        [TestMethod]
        public void DBStaffPasswordTestMethod()
        {
            var mockStaff = new Mock<Staff_tbl>();
            var staff = new Mock<IStaff>();
            staff.SetupGet(p => p.StaffId).Returns(1);
            staff.SetupGet(p => p.Staffpassword).Returns("1211");
            Assert.AreEqual("1211", staff.Object.Staffpassword);

        }
    }
}
