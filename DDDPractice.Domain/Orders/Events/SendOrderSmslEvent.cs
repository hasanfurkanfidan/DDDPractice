using MediatR;

namespace DDDPractice.Domain.Orders.Events
{
    public class SendOrderSmslEvent : INotificationHandler<OrderDomainEvent>
    {
        public Task Handle(OrderDomainEvent notification, CancellationToken cancellationToken)
        {
            //Sms Gönderme işlemi
            return Task.CompletedTask;
        }
    }
}
