using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RealEstatePlace.Data.Entities;
using RealEstatePlace.ViewModels;

namespace RealEstatePlace.Data
{
    public class RealEstateMappingProfile : Profile
    {
        public RealEstateMappingProfile()
        {
            CreateMap<Order, OrderViewModel>()
                .ForMember(o => o.OrderId, ex => ex.MapFrom(o => o.Id))
                .ReverseMap();
            CreateMap<OrderItem, OrderItemViewModel>()
                .ReverseMap();
        }
    }
}
