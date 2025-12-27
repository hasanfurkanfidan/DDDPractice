using DDDPractice.Domain.Users;
using MediatR;

namespace DDDPractice.Application.Features.Users.GetAllUser
{
    public class GetAllUserQueryHandler(IUserRepository userRepository) : IRequestHandler<GetAllUserQuery, List<User>>
    {
        public async Task<List<User>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            return await userRepository.GetAllAsync();
        }
    }
}
