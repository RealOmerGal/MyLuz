using Common.Entities;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using ServiceType.Service.Dtos;

namespace ServiceType.Service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiceTypeController : ControllerBase
    {
        private readonly IServiceTypeRepository _repository;
        private readonly IBus _eventBus;
        public ServiceTypeController(IServiceTypeRepository repository, IBus eventBus)
        {
            this._eventBus = eventBus;
            this._repository = repository;
        }
        private async Task<MassTransit.ISendEndpoint> GetEndPoint()
        {
            var uri = new Uri("rabbitmq://localhost/ServiceTypeQueue");
            return await _eventBus.GetSendEndpoint(uri);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceTypeDto createServiceTypeDto)
        {
            var endpoint = await GetEndPoint();
            var serviceType = await _repository.AddServiceType(createServiceTypeDto);
            await endpoint.Send(serviceType);
            return Ok(serviceType);
        }
        [HttpGet("{id}")]
        public IActionResult GetOne(Guid id)
        {
            return Ok(_repository.GetServiceType(id));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetServiceTypes());
        }
        // [HttpPut("{id}")]
        // public IActionResult Edit(Guid id, UpdateServiceTypeDto updateServiceTypeDto)
        // {
        //     updateServiceTypeDto.Id = id;
        //     return Ok(_repository.EditServiceType(updateServiceTypeDto));
        // }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _repository.DeleteServiceType(id);
            return NoContent();
        }
    }
}