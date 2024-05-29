namespace BoardGameScorer.Infrastructure.Repositories;
public class PlayerRepository(ApplicationDbContext context) : IPlayerRepository
{
	public async Task<List<Player>> GetAllAsync()
	{
		var result = await context.Players.ToListAsync();
		return result;
	}
	public async Task<Player> GetByIdAsync(int playerId)
	{

		var result = await context.Players.SingleOrDefaultAsync(p => p.Id == playerId);
		if (result is not null)
		{
			return result;
		}
		return null;
	}

	public async Task<Player> UpdateAsync(Player player)
	{
		var result = await context.Players.SingleOrDefaultAsync(p => p.Id == player.Id);
		if (result is not null)
		{
			context.Players.Update(player);
			await context.SaveChangesAsync();
			return result;
		}
		return null;
	}

	public async Task<Player> AddAsync(Player player)
	{
		var result = await context.Players.AddAsync(player);
		await context.SaveChangesAsync();
		return result.Entity;
	}
	public async Task<List<Player>> GetPlayerByPlaySessionId(int playSessionId)
	{
		return await context.Players.Where(p => p.PlaySessionId == playSessionId).ToListAsync();
	}
}
