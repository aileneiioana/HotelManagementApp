using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApplication.Models
{
    public interface IClient
    {
        int ClientId { get; set; }
        string ClientName { get; set; }
        string ClientPhone { get; set; }
        string ClientCountry { get; set; }
    }
}

