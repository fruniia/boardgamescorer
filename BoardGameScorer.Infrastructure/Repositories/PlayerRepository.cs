namespace BoardGameScorer.Infrastructure.Repositories;
public class PlayerRepository(ApplicationDbContext context) : IPlayerRepository
{
    public List<Player> GetAllAsync(int playsessionId)
    {
        var result = context.Players.ToList();
        return result;
    }
    public async Task<Player> GetByIdAsync(int playerId)
    {
        var result = await context.Players.FirstOrDefaultAsync(p => p.Id == playerId);
        return result;
    }

    public async Task UpdateAsync(Player player)
    {
        context.Players.Update(player);
        context.SaveChanges();
    }
}
