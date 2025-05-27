using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Core.Entities
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }

        [Required]
        public int HotelId { get; set; }

        [Required]
        public int RoomTypeId { get; set; }

        [Required]
        public int RoomNumber { get; set; }

        [Required]
        public int RoomStatusId { get; set; }

        // Navigation properties
        public Hotel Hotel { get; set; } = null!;
        public RoomType RoomType { get; set; } = null!;
        public RoomStatus RoomStatus { get; set; } = null!;
    }
}
