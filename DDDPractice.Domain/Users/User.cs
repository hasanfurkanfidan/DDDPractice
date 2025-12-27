using DDDPractice.Domain.Abstractions;
using DDDPractice.Domain.Shared;

namespace DDDPractice.Domain.Users
{
    public sealed class User : Entity
    {
        public User(Guid id, Name name, Email email, Password password, Address address) : base(id)
        {
            Name = name;
            Email = email;
            Password = password;
            Address = address;
        }

        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public Password Password { get; private set; }
        public Address Address { get; private set; }

        public void ChangeName(string newName)
        {
            Name = new(newName);
        }

        public void ChangeAddress(string country, string city, string street, string fullAddress, string postalCode)
        {
            Address = new(country, city, street, fullAddress, postalCode);
        }

        public void ChangeEmail(string newEmail)
        {
            Email = new(newEmail);
        }

        public void ChangePassword(string newPassword)
        {
            Password = new(newPassword);
        }
    }
}
