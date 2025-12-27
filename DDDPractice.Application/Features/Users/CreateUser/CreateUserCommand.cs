using MediatR;

namespace DDDPractice.Application.Features.Users.CreateUser
{
    public sealed record CreateUserCommand(string Name, string Email, string Country, string City, string Street, string FullAddress, string PostalCode) : IRequest;
}
