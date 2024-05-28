namespace BoardGameScorer.Domain.Entities;
public class PlaySession : BaseEntity
{
	public int UserId { get; set; }
	public int GameId { get; set; }
	public DateTime Date { get; set; }
	public List<Player> Players { get; set; } = [];
}
