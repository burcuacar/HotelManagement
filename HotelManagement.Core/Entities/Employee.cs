using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Core.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public string ContactNumber { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public int DepartmentId { get; set; }

        [Required]
        public int AddressId { get; set; }

        [Required]
        public int HotelId { get; set; }

        [Required]
        public int EmployeeStatusId { get; set; }

        public Department Department { get; set; } = null!;
        public Address Address { get; set; } = null!;
        public Hotel Hotel { get; set; } = null!;
        public EmployeeStatus EmployeeStatus { get; set; } = null!;
        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
