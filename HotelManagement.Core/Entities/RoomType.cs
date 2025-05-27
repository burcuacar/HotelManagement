using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Core.Entities
{
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public decimal Cost { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public bool SmokeFriendly { get; set; }

        [Required]
        public bool PetFriendly { get; set; }

        [Required]
        public int RoomTypeStatusId { get; set; }

        // Navigation
        public RoomTypeStatus RoomTypeStatus { get; set; } = null!;
        public ICollection<Room> Rooms { get; set; } = new List<Room>();
    }
}
