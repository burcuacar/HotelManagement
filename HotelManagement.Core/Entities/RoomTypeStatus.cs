using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Core.Entities
{
    public class RoomTypeStatus
    {
        [Key]
        public int RoomTypeStatusId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        // Navigation
        public ICollection<RoomType> RoomTypes { get; set; } = new List<RoomType>();
    }
}
