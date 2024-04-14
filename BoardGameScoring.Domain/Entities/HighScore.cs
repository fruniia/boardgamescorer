namespace BoardGameScoring.Domain.Entities;
public class HighScore
{
	public int PlayerId { get; set; }
	public int GameId { get; set; }
	public int Score { get; set; }
	public DateTime Date { get; set; }
}
