namespace BoardGameScorer.Application.Interfaces.Repositories;
public interface IEntityRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync();
    Task AddAsync(T value);
    Task UpdateAsync(T value);
    Task DeleteAsync(int id);
}
