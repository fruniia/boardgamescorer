namespace BoardGameScorer.WebUI.Server.Components.Pages.Kingdomino;
public partial class Kingdomino
{
	private EditContext? _editContext;
	[SupplyParameterFromForm]
	public KingdominoScoreEntry? Model { get; set; }
	private readonly List<KingdominoScoreEntry> _registration = [];
	public TileManager? TileManager { get; set; }
	bool canAddTile = false;

	protected override void OnInitialized()
	{
		TileManager = new();
		Model ??= new();
		_editContext = new(Model);
		base.OnInitialized();
	}
	private void HandleSubmit()
	{
		if (Model!.Tiles < Model!.Crowns)
		{
			Model = new KingdominoScoreEntry();
			_editContext = new EditContext(Model);
		}
		else
		{
			canAddTile = TileManager!.AddTile(Model.Terrain, Model.Crowns, Model.Tiles);
			if (canAddTile)
			{
				Model.TileScore = Model.CalculateTileScore();
				Model.ScoreHistory.Add(Model.TileScore);
				_registration.Add(Model);
				canAddTile = !canAddTile;
			}
			Model = new KingdominoScoreEntry();
			_editContext = new EditContext(Model);
		}
	}
	private int CalculateTotalScore()
	{
		return _registration.SelectMany(x => x.ScoreHistory).Sum();
	}
}
