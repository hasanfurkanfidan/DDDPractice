using DDDPractice.Domain.Abstractions;
using DDDPractice.Domain.Categories;
using MediatR;

namespace DDDPractice.Application.Features.Categories.CreateCategory
{
    public class CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateCategoryCommand>
    {
        public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            await categoryRepository.CreateAsync(request.Name, cancellationToken);
            await unitOfWork.SaveChangesAsync();
        }
    }
}
