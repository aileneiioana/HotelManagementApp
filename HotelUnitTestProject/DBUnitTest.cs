using HotelManagementApplication;
using HotelManagementApplication.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
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

         [TestMethod]
        public void DBReservationFreeRoomTestMethod()
        {
            var mockRes = new Mock<Reservation_tbl>();
            var mockRoom = new Mock<Room_tbl>();
            var res = new Mock<IReservation>();
            var room = new Mock<IRoom>();
            res.SetupGet(p => p.ResId).Returns(1);
            res.SetupGet(p => p.Room).Returns(101);
            room.SetupGet(p => p.RoomId).Returns(101);    
            room.SetupGet(p => p.RoomFree).Returns("busy");
            Assert.AreEqual(room.Object.RoomId, res.Object.Room);
        }

        [TestMethod]
        public void DBFreeRoomTestMethod()
        {
            var mockRoom = new Mock<Room_tbl>();
            var room = new Mock<IRoom>();
            room.SetupGet(p => p.RoomId).Returns(101);
            room.SetupGet(p => p.RoomFree).Returns("busy");
            Assert.AreEqual(room.Object.RoomFree, "busy");
        }

        [TestMethod]
        public void DBBusyRoomTestMethod()
        {
            var mockRoom = new Mock<Room_tbl>();
            var room = new Mock<IRoom>();
            room.SetupGet(p => p.RoomId).Returns(102);
            room.SetupGet(p => p.RoomFree).Returns("free");
            Assert.AreEqual(room.Object.RoomFree, "free");
        }

    }
}
