using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.Identity;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(d => d.Warehouse, o => o.MapFrom(s => s.Warehouse.Name))
                .ForMember(d => d.Grade, o => o.MapFrom(s => s.Grade.Name))
                .ForMember(d => d.LotNumber, o => o.MapFrom(s => s.LotNumber.Name))
                .ForMember(d => d.Packaging, o => o.MapFrom(s => s.Packaging.Name))
                .ForMember(d => d.Status, o => o.MapFrom(s => s.Status.Name));
            CreateMap<Address, AddressDto>().ReverseMap();
        }
    }
}