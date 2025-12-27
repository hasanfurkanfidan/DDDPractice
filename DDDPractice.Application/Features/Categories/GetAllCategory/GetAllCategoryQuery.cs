using DDDPractice.Domain.Categories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDPractice.Application.Features.Categories.GetAllCategory
{
    public sealed record  GetAllCategoryQuery : IRequest<List<Category>>;
}
