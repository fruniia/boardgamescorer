﻿namespace BoardGameScorer.Domain.Models;
public class KingdominoPlayer
{
	public int Id { get; set; }
	[Required]
	public string Name { get; set; } = string.Empty;
	public int Score { get; set; } = 0;
	public int TotalScore { get; set; } = 0;
}