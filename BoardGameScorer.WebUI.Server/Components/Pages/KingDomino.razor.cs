namespace BoardGameScorer.WebUI.Server.Components.Pages;

public partial class KingDomino
{
	private EditContext? EditContext;
	private GameScore gameScore = new GameScore();

	protected override void OnInitialized()
	{
		EditContext = new EditContext(gameScore);
		base.OnInitialized();
	}

	public class GameScore
	{
		public Terrain Terrain { get; set; }
		public Crown Crown { get; set; }
		public TileWithCrown TileWithCrown { get; set; }
		public int Tiles { get; set; }
	}
}