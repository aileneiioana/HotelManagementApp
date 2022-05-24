using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApplication.Models
{
    public interface IRoom
    {
        int RoomId { get; set; }
        string RoomPhone { get; set; }
        string RoomFree { get; set; }
    }
}
