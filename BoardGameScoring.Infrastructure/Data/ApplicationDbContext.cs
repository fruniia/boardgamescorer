using BoardGameScoring.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BoardGameScoring.Infrastructure.Data;
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
	public DbSet<Game> Games { get; set; }
	public DbSet<Player> Players { get; set; }
	public DbSet<Score> Scores { get; set; }
	public DbSet<HighScore> HighScores { get; set; }
}
