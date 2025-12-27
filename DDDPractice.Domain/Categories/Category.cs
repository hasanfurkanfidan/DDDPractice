using DDDPractice.Domain.Abstractions;
using DDDPractice.Domain.Products;
using DDDPractice.Domain.Shared;

namespace DDDPractice.Domain.Categories
{
    public sealed class Category : Entity
    {
        public Category(Guid id, Name name) : base(id)
        {
            Name = name;
        }

        public Name Name { get; private set; }
        public ICollection<Product> Products { get; private set; }

        public void ChangeName(Name newName)
        {
            Name = newName;
        }
    }
}
