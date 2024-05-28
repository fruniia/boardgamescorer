namespace BoardGameScorer.WebUI.Server.Components.Pages;
public partial class ListOfGames
{
	[Inject]
	GameService? GameService { get; set; }
	public IEnumerable<Game>? Games { get; set; }
	protected async override Task OnInitializedAsync()
	{
		Games = await GameService!.GetAllGames();
	}
}