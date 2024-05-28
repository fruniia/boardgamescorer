namespace BoardGameScorer.WebUI.Server.Components.Pages.Kingdomino;
public partial class PlayerSetup
{
	EditContext? _editContext;
	[SupplyParameterFromForm(FormName = "addPlayers")]
	[Parameter]
	public KingDominoPlayerSetup? SetUp { get; set; }
	private bool _hasPlayers = false;

	protected override void OnInitialized()
	{
		SetUp ??= new();
		_editContext = new(SetUp);
		SetUp.Players = gameService.GetPlayers();
	}

	private void AddNumberOfPlayers()
	{
		if (SetUp!.NumberOfPlayers > 0)
		{
			if (_hasPlayers)
			{
				ChangeNumberOfPlayers();
			}
			else
			{
				AddPlayer();
			}
		}
	}
	private void ChangeNumberOfPlayers()
	{
		SetUp!.Players.Clear();
		foreach (var player in SetUp.Players)
		{
			gameService.UpdatePlayer(player);
		}
		_hasPlayers = false;
		AddPlayer();
	}
	private void AddPlayer()
	{
		if (SetUp!.NumberOfPlayers >= 2 && SetUp!.NumberOfPlayers <= 4)
		{
			for (int i = 0; i < SetUp.NumberOfPlayers; i++)
			{
				var newId = GenerateUniqueId();
				gameService.AddPlayers(new KingdominoPlayer { Id = newId });
			}
			_hasPlayers = true;
		}
	}
	private void SavePlayer()
	{
		foreach (var player in SetUp!.Players)
		{
			var update = gameService.GetPlayerById(player.Id);
			if (update is not null)
			{
				update.Name = player.Name;
				gameService.UpdatePlayer(update);
				_hasPlayers = true;
			}
		}
	}
	private int GenerateUniqueId()
	{
		return SetUp!.Players.Count > 0 ? SetUp.Players.Max(p => p.Id) + 1 : 1;
	}
}