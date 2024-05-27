namespace BoardGameScorer.Domain.Models;
public class KingDominoPlayerSetup
{
	[Range(2, 4, ErrorMessage = $"{nameof(NumberOfPlayers)} must be between 2 and 4")]
	public int NumberOfPlayers { get; set; }
	public List<KingdominoPlayer> Players { get; set; } = [];
}
