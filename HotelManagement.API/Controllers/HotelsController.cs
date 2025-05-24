using HotelManagement.Service.DTOs.Hotel;
using HotelManagement.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace HotelManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelDto>>> GetHotels()
        {
            Log.Information("GetHotels endpoint.");
            var hotels = await _hotelService.GetAllHotelsAsync();
            return Ok(hotels);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HotelDto>> GetHotel(int id)
        {
            var hotel = await _hotelService.GetHotelByIdAsync(id);

            if (hotel == null)
            {
                return NotFound();
            }

            return Ok(hotel);
        }

        [HttpPost]
        public async Task<ActionResult<HotelDto>> PostHotel([FromBody] CreateHotelDto createHotelDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _hotelService.AddHotelAsync(createHotelDto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotel(int id, [FromBody] UpdateHotelDto updateHotelDto)
        {
            if (id != updateHotelDto.Id)
            {
                return BadRequest("ID mismatch");
            }

            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _hotelService.UpdateHotelAsync(updateHotelDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            await _hotelService.DeleteHotelAsync(id);

            return NoContent();
        }
    }
}
