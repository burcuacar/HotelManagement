using Microsoft.AspNetCore.SignalR;

namespace HotelManagement.API.Hubs
{
    public class ReservationHub: Hub
    {
        public async Task NotifyNewReservation(object reservationDto)
        {
            await Clients.All.SendAsync("ReceiveReservationNotification", reservationDto);
        }
    }
}
