namespace BoardGameScoring.Domain.Entities;

public class Game
{
	public int Id { get; set; }
	public required string Name { get; set; }
	public required string Description { get; set; }
}
