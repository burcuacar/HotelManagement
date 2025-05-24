using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Service.DTOs.UserLogin
{
    public class UserLoginDto
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}
