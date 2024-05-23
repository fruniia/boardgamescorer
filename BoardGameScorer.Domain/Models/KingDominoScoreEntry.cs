namespace BoardGameScorer.Domain.Models;
public class KingdominoScoreEntry
{
	public string PlayerName { get; set; } = string.Empty;
	[Required(ErrorMessage = "Terrain needs to be selected")]
	public Terrain Terrain { get; set; } = Terrain.Wheat;
	//public string? Terrain { get; set; }
	[Required]
	[Range(0, 6, ErrorMessage = $"{nameof(Crown)} must be between 0 and 6")]
	public int Crowns { get; set; }
	[Required]
	[Range(1, 24, ErrorMessage = $"{nameof(Tiles)} must be between 1 and 24")]
	public int Tiles { get; set; } = 1;
	public int TileScore { get; set; }
	public List<int> ScoreHistory { get; set; } = [];
	public int CalculateTileScore() => Crowns is 0 ? 0 : Tiles * Crowns;
}
