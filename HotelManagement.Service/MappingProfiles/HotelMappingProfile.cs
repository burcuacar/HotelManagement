using AutoMapper;
using HotelManagement.Core.Entities;
using HotelManagement.Service.DTOs.Address;
using HotelManagement.Service.DTOs.Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Service.MappingProfiles
{
    public class HotelMappingProfile : Profile
    {
        public HotelMappingProfile()
        {
            CreateMap<Hotel, HotelDto>()
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
                .ReverseMap();

            CreateMap<Hotel, CreateHotelDto>().ReverseMap();

            CreateMap<Hotel, UpdateHotelDto>().ReverseMap();

            CreateMap<Address, AddressDto>().ReverseMap();
        }
    }
}
