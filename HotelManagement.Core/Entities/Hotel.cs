using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Core.Entities
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int AddressId { get; set; }
        public Address Address { get; set; } = null!;
    }
}
