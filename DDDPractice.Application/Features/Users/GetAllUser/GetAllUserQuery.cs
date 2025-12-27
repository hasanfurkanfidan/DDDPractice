using DDDPractice.Domain.Users;
using MediatR;

namespace DDDPractice.Application.Features.Users.GetAllUser
{
    public sealed record GetAllUserQuery : IRequest<List<User>>;
}
