using AutoMapper;
using Common.Entities;
using ServiceType.Service.Dtos;

namespace ServiceType.Service.Maps
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CreateServiceTypeDto, ServiceTypeEntity>();
        }
    }
}