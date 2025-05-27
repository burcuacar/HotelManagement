using HotelManagement.Core.Entities;
using HotelManagement.Service.DTOs.Address;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Service.DTOs.Hotel
{
    public class HotelDto
    {
        public int HotelId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public int AddressId { get; set; } 
        public AddressDto Address { get; set; } = null!;
        public string Email { get; set; } = string.Empty;

        public int RoomCapacity { get; set; }

        public decimal? Rating { get; set; }

        public bool Status { get; set; }

    }
}
