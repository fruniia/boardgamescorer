

namespace BoardGameScorer.Application.Interfaces;
public interface IPlayerRepository
{
	List<Player> GetPlayers();
	Player GetPlayer(int playerId);
}
