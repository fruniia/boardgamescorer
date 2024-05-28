namespace BoardGameScorer.Domain.Entities;
public class Game : BaseEntity
{
	public required string Name { get; set; }
	public required string Description { get; set; }
}