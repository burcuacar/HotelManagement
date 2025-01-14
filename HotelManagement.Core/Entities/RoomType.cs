using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Core.Entities
{
    public class RoomType
    {
        public int Id { get; set; }
        public string TypeName { get; set; } = string.Empty; 
        public decimal Price { get; set; }
    }
}
