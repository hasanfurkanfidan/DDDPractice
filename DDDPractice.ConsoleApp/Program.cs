// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Guid id = Guid.NewGuid();
Entity a1 = new A(id);
Entity a2 = new A(id);

Console.WriteLine(a1.Equals(a2));

public abstract class Entity
{
    public Guid Id { get; init; }
    public Entity(Guid id)
    {
        Id = id;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null)
            return false;

        if (obj is not Entity entity)
            return false;

        if (obj.GetType() != GetType())
            return false;

        return entity.Id == Id;
    }
}


public class A : Entity
{
    public A(Guid id) : base(id)
    {
    }
}
