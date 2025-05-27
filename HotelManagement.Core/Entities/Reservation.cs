using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Core.Entities
{
    public class Reservation
    {
        [Key]
        public long ReservationId { get; set; } // bigint

        [Required]
        public int GuestId { get; set; }
        [Required]
        public int RoomId { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public int ReservationStatusId { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }

        public decimal? TotalAmount { get; set; }

        public string? AdditionalNotes { get; set; }

        public Guest Guest { get; set; } = null!;
        public Room Room { get; set; } = null!;
        public Employee Employee { get; set; } = null!;
        public ReservationStatus ReservationStatus { get; set; } = null!;
    }
}
