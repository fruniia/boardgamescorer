namespace BoardGameScorer.Application.Interfaces.Repositories;
public interface IPlayerRepository
{
	Task<List<Player>> GetAllAsync();
	Task<Player> GetByIdAsync(int playerId);
	Task<Player> UpdateAsync(Player player);
	Task<List<Player>> GetPlayerByPlaySessionId(int playSessionId);
}
