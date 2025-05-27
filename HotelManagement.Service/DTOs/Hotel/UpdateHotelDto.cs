using HotelManagement.Service.DTOs.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Service.DTOs.Hotel
{
    public class UpdateHotelDto
    {
        public int HotelId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public int AddressId { get; set; }
        public string Email { get; set; } = string.Empty;
        public int RoomCapacity { get; set; }
        public decimal? Rating { get; set; }
        public bool Status { get; set; }
    }
}
