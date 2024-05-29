namespace BoardGameScorer.Infrastructure.Repositories;
public class PlaySessionRepository(ApplicationDbContext context) : IEntityRepository<PlaySession>
{
    public async Task AddAsync(PlaySession value)
    {
        if (value is null)
        {
            throw new ArgumentNullException(nameof(value), "User cannot be null");
        }
        await context.PlaySessions.AddAsync(value);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var result = await context.PlaySessions.FindAsync(id);
        if (result is not null)
        {
            context.PlaySessions.Remove(result);
            context.SaveChanges();
        }
    }

    public async Task<List<PlaySession>> GetAllAsync()
    {
        return await context.PlaySessions.ToListAsync();
    }

    public async Task<PlaySession> GetByIdAsync(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("ID must be greater than zero", nameof(id));
        }
        return await context.PlaySessions.FindAsync(id);
    }

    public async Task UpdateAsync(PlaySession value)
    {
        context.PlaySessions.Update(value);
        await context.SaveChangesAsync();
    }
}
