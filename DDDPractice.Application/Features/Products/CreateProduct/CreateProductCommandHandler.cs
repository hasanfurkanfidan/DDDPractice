using DDDPractice.Domain.Abstractions;
using DDDPractice.Domain.Products;
using MediatR;

namespace DDDPractice.Application.Features.Products.CreateProduct
{
    internal class CreateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateProductCommand>
    {
        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            await productRepository.CreateAsync(request.Name, request.Quantity, request.Amount, request.Currency, request.CategoryId, cancellationToken);
            await unitOfWork.SaveChangesAsync();
        }
    }
}
