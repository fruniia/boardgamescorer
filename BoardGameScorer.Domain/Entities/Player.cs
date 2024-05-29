namespace BoardGameScorer.Domain.Entities;
public class Player : BaseEntity
{
	public string? Name { get; set; }
	public int Score { get; set; }
	public int PlaySessionId { get; set; }
	public PlaySession? PlaySession { get; init; }
}
