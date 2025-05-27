using HotelManagement.Core.Entities;
using HotelManagement.Service.DTOs.Hotel;
using HotelManagement.Service.DTOs.QueryParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Service.Services
{
    public interface IHotelService
    {
        Task<IEnumerable<HotelDto>> GetAllHotelsAsync(HotelQueryParameters queryParameters);
        Task<HotelDto> GetHotelByIdAsync(int id);
        Task AddHotelAsync(CreateHotelDto hotel);
        Task UpdateHotelAsync(UpdateHotelDto hotel);
        Task DeleteHotelAsync(int id);
    }
}
