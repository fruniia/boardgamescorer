namespace BoardGameScorer.Application.Interfaces.Repositories;
public interface IPlayerRepository
{
    List<Player> GetAllAsync(int playSessionId);
    Task<Player> GetByIdAsync(int playerId);
    Task UpdateAsync(Player player);
}
