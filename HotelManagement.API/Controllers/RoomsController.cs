using HotelManagement.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly HotelManagementDbContext _context;
        public RoomsController(HotelManagementDbContext context)
        {
            _context = context;
        }
    }
}
