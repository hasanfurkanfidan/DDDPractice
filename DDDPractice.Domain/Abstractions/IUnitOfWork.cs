namespace DDDPractice.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
