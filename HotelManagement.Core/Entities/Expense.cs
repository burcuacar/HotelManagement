using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Core.Entities
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public int ExpenseTypeId { get; set; }

        public string? Description { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime ExpenseDate { get; set; }

        [Required]
        public int ExpenseStatusId { get; set; }

        public Employee Employee { get; set; } = null!;
        public ExpenseType ExpenseType { get; set; } = null!;
        public ExpenseStatus ExpenseStatus { get; set; } = null!;
    }
}
