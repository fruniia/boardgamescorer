namespace BoardGameScorer.Domain.Models;

public class KingDominoGame
{
	[Required]
	public string? Terrain { get; set; }
	[Required]
	[Range(0, 6, ErrorMessage = $"{nameof(Crown)} must be between 0 and 6")]
	public int Crowns { get; set; }
	[Required]
	[Range(1, 24, ErrorMessage = $"{nameof(Tiles)} must be between 1 and 24")]
	public int Tiles { get; set; }
}
