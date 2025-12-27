using DDDPractice.Domain.Abstractions;
using DDDPractice.Domain.Users;
using MediatR;

namespace DDDPractice.Application.Features.Users.CreateUser
{
    public class CreateUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateUserCommand>
    {
        public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            await userRepository.CreateAsync(request.Name, request.Email, request.Country, request.City, request.Street, request.FullAddress, request.PostalCode, cancellationToken);
            await unitOfWork.SaveChangesAsync();
        }
    }
}
