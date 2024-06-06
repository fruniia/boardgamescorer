namespace BoardGameScorer.WebUI.Server.Components.Pages.Kingdomino;
public partial class Kingdomino
{
	private EditContext? _editContext;
	[SupplyParameterFromForm]
	public KingdominoScoreEntry? Model { get; set; }
	private readonly List<KingdominoScoreEntry> _registration = [];
	public TileManager? TileManager { get; set; }
	private bool _canAddTile = false;


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
			ResetModel();
		}
		else
		{
			_canAddTile = TileManager!.AddTile(Model.Terrain, Model.Crowns, Model.Tiles);
			if (_canAddTile)
			{
				UpdateModel();
			}
			ResetModel();
		}
	}
	private void ResetModel()
	{
		Model = new();
		_editContext = new(Model);
		_message = string.Empty;
	}
	private void UpdateModel()
	{
		Model!.TileScore = Model.CalculateTileScore();
		Model.ScoreHistory.Add(Model.TileScore);
		_registration.Add(Model);
		_canAddTile = true;
	}
	private int CalculateTotalScore()
	{
		return _registration.SelectMany(x => x.ScoreHistory).Sum();
	}
}
