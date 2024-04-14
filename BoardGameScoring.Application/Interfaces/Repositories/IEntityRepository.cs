namespace BoardGameScoring.Application.Repositories;
internal interface IEntityRepository<T> where T : class
{
	Task<T> GetByIdAsync(int id);
	Task<List<T>> GetAllAsync();
	Task<T> AddAsync(T value);
	Task<T> UpdateAsync(T value);
	void DeleteAsync(int id);
}
