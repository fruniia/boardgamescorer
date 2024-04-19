namespace BoardGameScorer.Domain.Entities;
public class Score : BaseEntity
{
	public int PlayerId { get; set; }
	public int GameId { get; set; }
	public DateTime Date { get; set; }
}
