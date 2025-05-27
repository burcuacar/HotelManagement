using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Core.Entities
{
    public class RoomStatus
    {
        [Key]
        public int RoomStatusId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        // Navigation
        public ICollection<Room> Rooms { get; set; } = new List<Room>();
    }

}
