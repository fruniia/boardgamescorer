//TODO: Renaming
namespace BoardGameScorer.Application.Services.Kingdomino;
public class GamesService : IGamesService<KingdominoPlayer>
{
	private List<KingdominoPlayer> _players = [];
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
		var player = _players.FirstOrDefault(p => p.Id == playerId);
		return player;
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

	public void SetPlayers(List<KingdominoPlayer> players)
	{
		_players = players;
	}

	public void ResetPlayers()
	{
		Player = new();
	}
}
