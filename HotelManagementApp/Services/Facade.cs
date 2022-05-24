using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApplication.Services
{
    public class Facade
    {
        //Facade design pattern
        private ClientServices _clientServices;
        private StaffServices _staffServices;
        private RoomServices _roomServices;
        private ReservationServices _reservationServices;

        public Facade()
        {
            _clientServices = new ClientServices();
            _staffServices = new StaffServices();
            _roomServices = new RoomServices();
            _reservationServices = new ReservationServices();
        }

        public void addClient (Client_tbl client)
        {
            _clientServices.AddClient(client);
        }
    }
}
