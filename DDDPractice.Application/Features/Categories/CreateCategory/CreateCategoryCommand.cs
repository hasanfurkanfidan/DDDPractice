using MediatR;

namespace DDDPractice.Application.Features.Categories.CreateCategory
{
    public sealed record CreateCategoryCommand(string Name) : IRequest;
}
