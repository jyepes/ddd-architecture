using System;
using AutoMapper;
using Domain.Entity;
using Application.DTO;

namespace Transversal.Mapper
{
    public class MappingsProfile: Profile
    {
        public MappingsProfile()
        {
            //Si las entidades de origen y destino tienen los mismos nombre de atributos
            CreateMap<Customer, CustomerDto>().ReverseMap();

            //Si los nombre de atributos fueran diferentes en la entidad origen y en la entidad de destino
            //CreateMap<Customer, CustomerDto>().ReverseMap()
            //    .ForMember(destination => destination.CustomerID, source => source.MapFrom(src => src.CustomerID))
            //    .ForMember(destination => destination.CompanyName, source => source.MapFrom(src => src.CompanyName))
            //    .ForMember(destination => destination.ContactName, source => source.MapFrom(src => src.ContactName));
                    
        }

    }
}
