using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Core.Entities
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string ContactNumber { get; set; } = string.Empty;

        [Required]
        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; } = null!;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public int RoomCapacity { get; set; }

        public decimal? Rating { get; set; }

        [Required]
        public bool Status { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<Room> Rooms { get; set; } = new List<Room>();
    }
}
