namespace BoardGameScorer.Infrastructure.Repositories;
public class GameRepository(ApplicationDbContext context) : IEntityRepository<Game>
{
    public async Task<List<Game>> GetAllAsync()
    {
        return await context.Games.ToListAsync();
    }
    public Task AddAsync(Game value)
    {
        throw new NotImplementedException();
    }
    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
    public Task<Game> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
    public Task UpdateAsync(Game value)
    {
        throw new NotImplementedException();
    }
}
