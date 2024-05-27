using BoardGameScorer.Application.Interfaces.Repositories;
using BoardGameScorer.Domain.Models;
namespace BoardGameScorer.Application.Services.Kingdomino;
public class GameService : IGameService<KingdominoPlayer>
{
	public readonly List<KingdominoPlayer> _players = [];
	public KingdominoPlayer Player { get; private set; } = new();

	public List<KingdominoPlayer> GetPlayers()
	{
		return _players;
	}
	public void AddPlayers(KingdominoPlayer player)
	{
		Player.Name = player.Name;
		_players.Add(player);
	}

	public KingdominoPlayer GetPlayerById(int playerId)
	{
		return _players.FirstOrDefault(p => p.Id == playerId);
	}

	public void UpdatePlayer(KingdominoPlayer player)
	{
		var existingPlayer = GetPlayerById(player.Id);
		if (existingPlayer is not null)
		{
			existingPlayer.Name = player.Name;
			existingPlayer.Score = player.Score;
			existingPlayer.TotalScore = player.TotalScore;
		}
	}
}
