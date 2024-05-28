namespace BoardGameScorer.Infrastructure.Repositories;
public class PlaySessionRepository(ApplicationDbContext context) : IEntityRepository<PlaySession>
{
	public async Task<PlaySession> AddAsync(PlaySession value)
	{
		var result = await context.PlaySessions.AddAsync(value);
		await context.SaveChangesAsync();
		return result.Entity;
	}

	public async void DeleteAsync(int id)
	{
		var result = await context.PlaySessions.FirstOrDefaultAsync(p => p.Id == id);
		if (result is not null)
		{
			context.PlaySessions.Remove(result);
		}
	}

	public async Task<List<PlaySession>> GetAllAsync()
	{
		return await context.PlaySessions.ToListAsync();
	}

	public async Task<PlaySession> GetByIdAsync(int id)
	{
		var result = await context.PlaySessions.Where(p => p.Id == id).FirstOrDefaultAsync();
		return result;
	}

	public async Task<PlaySession> UpdateAsync(PlaySession value)
	{
		var result = await context.PlaySessions.FirstOrDefaultAsync(p => p.Id == value.Id);
		if (result is not null)
		{
			result.Players = value.Players;
			result.UserId = value.UserId;
			result.GameId = value.GameId;
			await context.SaveChangesAsync();

			return result;
		}
		return null;
	}
}
