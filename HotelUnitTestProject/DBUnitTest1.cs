using HotelManagementApplication;
using HotelManagementApplication.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace HotelUnitTestProject
{
    [TestClass]
    public class DBUnitTest1
    {
        [TestMethod]

        public void DBClientNameTestMethod()
        {
          var mockClient = new Mock<Client_tbl>();
          var client = new Mock<IClient>();
          client.Setup(p => p.ClientId).Returns(1);
          client.SetupGet(p => p.ClientName).Returns("Robert");
          Assert.AreEqual("Robert", client.Object.ClientName);
        }

        [TestMethod]

        public void DBClientCountryTestMethod()
        {
            var mockClient = new Mock<Client_tbl>();
            var client = new Mock<IClient>();
            client.SetupGet(p => p.ClientId).Returns(1);
            client.SetupGet(p => p.ClientCountry).Returns("USA");
            Assert.AreEqual("USA", client.Object.ClientCountry);
        }

        [TestMethod]

        public void DBClientPhoneTestMethod()
        {
            var mockClient = new Mock<Client_tbl>();
            var client = new Mock<IClient>();
            client.Setup(p => p.ClientId).Returns(1);
            client.SetupGet(p => p.ClientPhone).Returns("54726");
            Assert.AreEqual("54726", client.Object.ClientPhone);
        }

        [TestMethod]
        public void DBFRoomIDTestMethod()
        {
            var mockRoom = new Mock<Room_tbl>();
            var room = new Mock<IRoom>();
            var room1 = GetDemoRoom();
            room.SetupGet(p => p.RoomId).Returns(105);
            room.SetupGet(p => p.RoomFree).Returns("free");
            Assert.AreEqual(room.Object.RoomId, room1.RoomId);
        }

        Room_tbl GetDemoRoom()
        {
            return new Room_tbl() { RoomId = 105, RoomPhone="98", RoomFree="free" };
        }

        [TestMethod]
        public void DBClientTestMethod()
        {
            var mockClient = new Mock<Client_tbl>();
            var client = new Mock<IClient>();
            var client1 = GetDemoClient();
            client.SetupGet(p => p.ClientId).Returns(2);
            client.SetupGet(p => p.ClientName).Returns("Ioana");
            Assert.AreEqual(client.Object.ClientId, client1.ClientId);
        }

        Client_tbl GetDemoClient()
        {
            return new Client_tbl() { ClientId = 2, ClientName= "Ioana", ClientCountry= "Austria", ClientPhone="07126"};
        }


    }


}
