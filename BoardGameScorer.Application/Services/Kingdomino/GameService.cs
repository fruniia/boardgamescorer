using BoardGameScorer.Domain.Models;
namespace BoardGameScorer.Application.Services.Kingdomino;
public class GameService
{
	public GameState State { get; set; } = new GameState();
}
