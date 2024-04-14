namespace BoardGameScoring.Domain.Entities;
public class Game : BaseAuditInfo
{
	public required string Name { get; set; }
	public required string Description { get; set; }
}