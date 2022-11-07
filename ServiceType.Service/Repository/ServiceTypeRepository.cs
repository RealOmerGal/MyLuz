using AutoMapper;
using Common.Entities;
using Microsoft.EntityFrameworkCore;
using ServiceType.Service.Dtos;

namespace ServiceType.Service
{
    public class ServiceTypeRepository : IServiceTypeRepository
    {
        private readonly DataContext _dbcontext;
        private readonly IMapper _mapper;
        public ServiceTypeRepository(DataContext dbContext, IMapper mapper)
        {
            this._mapper = mapper;
            this._dbcontext = dbContext;
        }
        public async Task<ServiceTypeEntity> AddServiceType(CreateServiceTypeDto createServiceTypeDto)
        {

            var serviceType = new ServiceTypeEntity();
            _mapper.Map(createServiceTypeDto, serviceType);
            await _dbcontext.ServiceTypes.AddAsync(serviceType);
            if (await _dbcontext.SaveChangesAsync() > 0)
            {
                return serviceType;
            }
            return null;
        }

        public async void DeleteServiceType(Guid id)
        {
            var serviceType = new ServiceTypeEntity { Id = id };
            _dbcontext.ServiceTypes.Remove(serviceType);
            await _dbcontext.SaveChangesAsync();
        }


        public async Task<bool> EditServiceType(ServiceTypeEntity updateDto)
        {
            _dbcontext.Entry(await _dbcontext.ServiceTypes
            .SingleOrDefaultAsync(x => x.Id == updateDto.Id))
            .CurrentValues.SetValues(updateDto);
            return (await _dbcontext.SaveChangesAsync()) > 0;
        }

        public async Task<ServiceTypeEntity> GetServiceType(Guid id)
        {
            var serviceType = await _dbcontext.ServiceTypes.SingleOrDefaultAsync(i => i.Id == id);
            return serviceType;
        }
        public async Task<List<ServiceTypeEntity>> GetServiceTypes()
        {
            var serviceTypes = await _dbcontext.ServiceTypes.ToListAsync();
            return serviceTypes;
        }

    }
}