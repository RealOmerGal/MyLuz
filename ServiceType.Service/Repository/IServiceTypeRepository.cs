
using Common.Entities;
using ServiceType.Service.Dtos;

namespace ServiceType.Service
{
    public interface IServiceTypeRepository
    {
        public Task<List<ServiceTypeEntity>> GetServiceTypes();
        public Task<ServiceTypeEntity> GetServiceType(Guid id);
        public Task<ServiceTypeEntity> AddServiceType(CreateServiceTypeDto createServiceTypeDto);
        public Task<bool> EditServiceType(ServiceTypeEntity updateDto);
        public void DeleteServiceType(Guid id);
    }
}