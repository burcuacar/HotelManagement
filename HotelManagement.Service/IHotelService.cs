using HotelManagement.Core.Entities;
using HotelManagement.Service.DTOs.Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Service
{
    public interface IHotelService
    {
        Task<IEnumerable<HotelDto>> GetAllHotelsAsync();
        Task<HotelDto> GetHotelByIdAsync(int id);
        Task AddHotelAsync(CreateHotelDto hotel);
        Task UpdateHotelAsync(UpdateHotelDto hotel);
        Task DeleteHotelAsync(int id);
    }
}
