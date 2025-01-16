using HotelManagement.Core.Entities;
using HotelManagement.Service.DTOs.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Service.DTOs.Hotel
{
    public class HotelDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int AddressId { get; set; } 
        public AddressDto Address { get; set; } = null!; 
    }
}
