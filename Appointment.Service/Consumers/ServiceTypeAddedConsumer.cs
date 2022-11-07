
using Common.Entities;
using MassTransit;

namespace Appointment.Service.Consumers
{
    public class ServiceTypeAddedConsumer : IConsumer<ServiceTypeEntity>
    {
        public async Task Consume(ConsumeContext<ServiceTypeEntity> context)
        {
            await Console.Out.WriteLineAsync($"Notification sent: todo id {context.Message.Id}");

        }
    }
}