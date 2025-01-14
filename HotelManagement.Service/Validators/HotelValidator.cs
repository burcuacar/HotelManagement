using FluentValidation;
using HotelManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Service.Validators
{
    public class HotelValidator: AbstractValidator<Hotel>
    {
        public HotelValidator()
        {
            RuleFor(h => h.Name).NotEmpty().WithMessage("Hotel name is required").
                Length(3, 100).WithMessage("Hotel name must be between 3 and 100 characters");

            RuleFor(h => h.Description).MaximumLength(500).WithMessage("Description cannot exceed 500 characters.");
            RuleFor(h => h.AddressId).GreaterThan(0).WithMessage("A valid AddressId is required.");
        }
    }
}
