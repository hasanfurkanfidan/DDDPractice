using DDDPractice.Domain.Categories;
using MediatR;

namespace DDDPractice.Application.Features.Categories.GetAllCategory
{
    public class GetAllCategoryQueryHandler(ICategoryRepository categoryRepository) : IRequestHandler<GetAllCategoryQuery, List<Category>>
    {
        public async Task<List<Category>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            return await categoryRepository.GetAllAsync();
        }
    }
}
