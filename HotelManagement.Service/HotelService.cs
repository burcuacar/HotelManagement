using AutoMapper;
using HotelManagement.Core.Entities;
using HotelManagement.Data.Repositories;
using HotelManagement.Service.DTOs.Hotel;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Service
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<HotelService> _logger;
        public HotelService(IHotelRepository hotelRepository, IMapper mapper, ILogger<HotelService> logger)
        {
            _hotelRepository = hotelRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task AddHotelAsync(CreateHotelDto createHotelDto)
        {
            var hotel=_mapper.Map<Hotel>(createHotelDto);
            await _hotelRepository.AddAsync(hotel);
        }

        public async Task DeleteHotelAsync(int id)
        {
            var hotel = await _hotelRepository.GetByIdAsync(id);
            if (hotel != null)
            {
                _hotelRepository.Remove(hotel);
            }
        }

        public async Task<IEnumerable<HotelDto>> GetAllHotelsAsync()
        {
            _logger.LogInformation("GetHotelsAsync method.");
            var hotels= await _hotelRepository.GetAllAsync();
            return _mapper.Map<List<HotelDto>>(hotels);
        }

        public async Task<HotelDto> GetHotelByIdAsync(int id)
        {
            var hotel= await _hotelRepository.GetByIdAsync(id);
            return _mapper.Map<HotelDto>(hotel);
        }

        public async Task UpdateHotelAsync(UpdateHotelDto updateHotelDto)
        {
            var hotel = _mapper.Map<Hotel>(updateHotelDto);
            await _hotelRepository.Update(hotel);
        }
    }
}
