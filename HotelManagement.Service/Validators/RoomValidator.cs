using FluentValidation;
using HotelManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Service.Validators
{
    public class RoomValidator: AbstractValidator<Room>
    {
        public RoomValidator()
        {
            RuleFor(r => r.RoomNumber)
                .NotEmpty().WithMessage("Room number is required.")
                .Length(1, 10).WithMessage("Room number must be between 1 and 10 characters.");

            RuleFor(r => r.RoomTypeId)
                .GreaterThan(0).WithMessage("A valid RoomTypeId is required.");

            RuleFor(r => r.HotelId)
                .GreaterThan(0).WithMessage("A valid HotelId is required.");
        }
    }
}
