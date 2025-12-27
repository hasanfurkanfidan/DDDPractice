using MediatR;

namespace DDDPractice.Domain.Orders.Events
{
    public class SendOrderEmailEvent : INotificationHandler<OrderDomainEvent>
    {
        public Task Handle(OrderDomainEvent notification, CancellationToken cancellationToken)
        {
            //Mail Gönderme işlemi
            return Task.CompletedTask;
        }
    }
}
