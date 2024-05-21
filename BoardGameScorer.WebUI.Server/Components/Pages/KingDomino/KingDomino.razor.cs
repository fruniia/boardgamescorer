namespace BoardGameScorer.WebUI.Server.Components.Pages.KingDomino;

public partial class KingDomino
{
	private EditContext? _editContext;

	[SupplyParameterFromForm]
	public KingDominoGameModel? Model { get; set; }
	private readonly List<KingDominoGameModel> _registration = [];

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
			_registration.Add(Model);
			Model = new();
		}
	}
}
