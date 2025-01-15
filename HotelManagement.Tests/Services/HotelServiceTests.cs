using FluentAssertions;
using HotelManagement.Core.Entities;
using HotelManagement.Data.Repositories;
using HotelManagement.Service;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Tests.Services
{
    public class HotelServiceTests
    {
        private readonly Mock<IHotelRepository> _hotelRepositoryMock;
        private readonly HotelService _hotelService;

        public HotelServiceTests()
        {
            _hotelRepositoryMock = new Mock<IHotelRepository>();
            _hotelService = new HotelService(_hotelRepositoryMock.Object);
        }

        [Fact]
        public async Task GetAllHotelsAsync_ShouldReturnAllHotels()
        {
            //Arrange
            var hotels = new List<Hotel>
            {
                new Hotel { Id = 1, Name = "Hotel A", AddressId = 1 },
                new Hotel { Id = 2, Name = "Hotel B", AddressId = 2 }
            };

            _hotelRepositoryMock.Setup(x => x.GetAllAsync()).ReturnsAsync(hotels);

            //Act
            var result = await _hotelService.GetAllHotelsAsync();

            //Assert
            result.Should().NotBeNull();
            result.Should().HaveCount(2);
            result.First().Name.Should().Be("Hotel A");
        }

        [Fact]
        public async Task GetHotelByIdAsync_ShouldReturnHotel_WhenHotelExist()
        {
            //Arrange
            var hotel = new Hotel { Id = 1, Name = "Hotel A", AddressId = 1 };
            _hotelRepositoryMock.Setup(x => x.GetByIdAsync(1)).ReturnsAsync(hotel);

            //Act
            var result = await _hotelService.GetHotelByIdAsync(1);

            //Assert
            result.Should().NotBeNull();
            result.Name.Should().Be("Hotel A");

        }

        [Fact]
        public async Task GetHotelByIdAsync_ShouldReturnNull_WhenHotelDoesNotExist()
        {
            //Arrange
            _hotelRepositoryMock.Setup(x => x.GetByIdAsync(99)).ReturnsAsync((Hotel)null);

            //Act 
            var result = await _hotelService.GetHotelByIdAsync(99);

            //Assert
            result.Should().BeNull();
        }

    }
}
