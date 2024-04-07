namespace BoardGameScoring.Domain.Entities;
internal class Score
{
    public int Id { get; set; }
    public int PlayerId { get; set; }
    public int GameId { get; set; }
    public DateTime Date { get; set; }
}
