namespace BoardGameScorer.WebUI.Server.Components.Pages.Kingdomino;
public partial class Kingdomino
{
	private EditContext? _editContext;
	[SupplyParameterFromForm]
	public KingdominoScoreEntry? Model { get; set; }
	private readonly List<KingdominoScoreEntry> _registration = [];

	protected override void OnInitialized()
	{
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
			Model.TileScore = Model.CalculateTileScore();
			Model.ScoreHistory.Add(Model.TileScore);
			_registration.Add(Model);
			Model = new KingdominoScoreEntry();
			_editContext = new EditContext(Model);
		}
	}
	private int CalculateTotalScore()
	{
		return _registration.SelectMany(x => x.ScoreHistory).Sum();
	}
}
