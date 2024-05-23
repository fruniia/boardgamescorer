namespace BoardGameScorer.WebUI.Server.Components.Pages.KingDomino;
public partial class KingDomino
{
	private EditContext? _editContext;

	[SupplyParameterFromForm]
	public KingDominoScoreEntry? Model { get; set; }
	private readonly List<KingDominoScoreEntry> _registration = [];

	protected override void OnInitialized()
	{
		Model ??= new();
		_editContext = new(Model);
		base.OnInitialized();
	}

	private void HandleSubmit()
	{
		if (Model!.Tiles > 0)
		{
			Model.TileScore = Model.CalculateTileScore();
			Model.ScoreHistory.Add(Model.TileScore);
			_registration.Add(Model);
			Model = new KingDominoScoreEntry();
			_editContext = new EditContext(Model);
		}
	}
	private int CalculateTotalScore()
	{
		return _registration.SelectMany(x => x.ScoreHistory).Sum();
	}
}
