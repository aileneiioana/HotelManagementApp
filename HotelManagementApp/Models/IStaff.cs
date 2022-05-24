using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApplication.Models
{
    public interface IStaff
    {
        int StaffId { get; set; }

        string Staffname { get; set; }

        string Staffpassword { get; set; }

        string Gender { get; set; }


    }
}
