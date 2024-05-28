namespace BoardGameScorer.Infrastructure.Repositories;
public class GameRepository(ApplicationDbContext context) : IEntityRepository<Game>
{
	public Task<Game> AddAsync(Game value)
	{
		throw new NotImplementedException();
	}

	public void DeleteAsync(int id)
	{
		throw new NotImplementedException();
	}

	public async Task<List<Game>> GetAllAsync()
	{
		return await context.Games.ToListAsync();
	}

	public Task<Game> GetByIdAsync(int id)
	{
		throw new NotImplementedException();
	}

	public Task<Game> UpdateAsync(Game value)
	{
		throw new NotImplementedException();
	}
}
