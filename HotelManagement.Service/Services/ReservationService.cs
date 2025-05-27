using AutoMapper;
using HotelManagement.Core.Entities;
using HotelManagement.Core.Interfaces;
using HotelManagement.Data.Repositories;
using HotelManagement.Service.DTOs.Reservation;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Service.Services
{
    public class ReservationService
    {
        private readonly IReservationNotificationService _notificationService;
        //private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<ReservationService> _logger;
        public ReservationService(IMapper mapper, ILogger<ReservationService> logger, IReservationNotificationService notificationService)
        {
            _notificationService = notificationService;
            _logger = logger;
            _mapper = mapper;   
        }

        public async Task<ReservationDTO> CreateReservationAsync(CreateReservationDto dto)
        {
            var reservation = _mapper.Map<Reservation>(dto);

            // Örnek: ilişkili Room, Guest, vb. varsa onlar da işlenir

            //await _reservationRepository.AddAsync(reservation);

            //var reservationDto = _mapper.Map<ReservationDto>(reservation);

            //// SignalR bildirimi tam burada yapılır:
            //await _notificationService.NotifyNewReservationAsync(reservationDto);

            return new ReservationDTO();
        }

    }
}
