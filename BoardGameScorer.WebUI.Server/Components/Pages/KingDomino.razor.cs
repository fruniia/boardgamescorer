namespace BoardGameScorer.WebUI.Server.Components.Pages;

public partial class KingDomino
{
	private EditContext? _editContext;

	[SupplyParameterFromForm]
	public KingDominoGame? Model { get; set; }
	private List<KingDominoGame> registration = new();
	string[] Terrains = Terrain.GetNames(typeof(Terrain));
	int[] Crowns = (int[])TileWithCrown.GetValues(typeof(TileWithCrown));

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
			registration.Add(Model);
			Model = new();
		}
	}
}
