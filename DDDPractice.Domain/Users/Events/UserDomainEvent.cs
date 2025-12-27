using MediatR;

namespace DDDPractice.Domain.Users.Events
{
    public class UserDomainEvent : INotification
    {
        public User User { get; set; }
        public UserDomainEvent(User user)
        {
            User = user;
        }
    }
}
