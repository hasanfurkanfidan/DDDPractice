using DDDPractice.Domain.Abstractions;
using DDDPractice.Domain.Shared;

namespace DDDPractice.Domain.Orders
{
    public sealed class Order : Entity
    {
        public Order(Guid id, string orderNumber, DateTime createdDate, OrderStatus status, ICollection<OrderLine> orderLines) : base(id)
        {
            OrderNumber = orderNumber;
            CreatedDate = createdDate;
            Status = status;
            OrderLines = orderLines;
        }

        public string OrderNumber { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public OrderStatus Status { get; private set; }
        public ICollection<OrderLine> OrderLines { get; private set; }

        public void CreateOrder(List<CreateOrderDto> createOrderDtos)
        {
            if (createOrderDtos == null || !createOrderDtos.Any())
            {
                throw new ArgumentException("Order must have at least one order line.", nameof(createOrderDtos));
            }

            foreach (var dto in createOrderDtos)
            {
                if (dto.Quantity < 1)
                {
                    throw new ArgumentException("Quantity must be at least 1.");
                }
                var orderLine = new OrderLine(Guid.NewGuid(), Id, dto.ProductId, dto.Quantity, new(dto.Amount, Currency.FromCode(dto.Currency)));
                OrderLines.Add(orderLine);
            }
        }

        public void RemoveOrderLine(Guid orderLineId)
        {
            var orderLine = OrderLines.FirstOrDefault(ol => ol.Id == orderLineId);
            if (orderLine == null)
            {
                throw new ArgumentException("Order line not found.", nameof(orderLineId));
            }
            OrderLines.Remove(orderLine);
        }
    }
}
