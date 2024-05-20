using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BoardGameScorer.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
	public DbSet<Game> Games { get; set; }
	//public DbSet<Player> Players { get; set; }
	//public DbSet<Score> Scores { get; set; }
	//public DbSet<HighScore> HighScores { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Game>().HasData(
			new Game
			{
				Id = 1,
				Name = "Kingdomino",
				Description = "In Kingdomino, you are a lord seeking new lands in which to expand your kingdom. You must explore all the lands, including wheat fields, lakes, and mountains, in order to spot the best plots, while competing with other lords to acquire them first.\r\n\r\nThe game uses tiles with two sections, similar to Dominoes. Each turn, each player will select a new domino to connect to their existing kingdom, making sure at least one of its sides connects to a matching terrain type already in play. The order of who picks first depends on which tile was previously chosen, with better tiles forcing players to pick later in the next round. The game ends when each player has completed a 5x5 grid (or failed to do so), and points are counted based on number of connecting tiles and valuable crown symbols."
			});

		modelBuilder.Entity<Game>().HasData(
			 new Game
			 {
				 Id = 2,
				 Name = "Queendomino",
				 Description = "Build up the most prestigious kingdom by claiming wheat fields, forests, lakes, grazing grounds, marshes, and mountains. Your knights will bring you riches in the form of coins — and if you make sure to expand the towns on your lands, you will make new buildings appear, giving you opportunities for new strategies. You may win the Queen's favors ... but always be aware of the dragon!\r\n\r\nQueendomino is a game completely independent from Kingdomino, while offering a choice of more complex challenges. Two to four players can play Queendomino independently, but also in connection with Kingdomino, allowing for games with 7x7 grids for four players, or for up to six players if you stick to 5x5 grids."
			 });
		modelBuilder.Entity<Game>().HasData(
		new Game
		{
			Id = 3,
			Name = "Ticket to Ride",
			Description = "With elegantly simple gameplay, Ticket to Ride can be learned in under 15 minutes. Players collect cards of various types of train cars they then use to claim railway routes in North America. The longer the routes, the more points they earn. Additional points come to those who fulfill Destination Tickets – goal cards that connect distant cities; and to the player who builds the longest continuous route.\r\n\r\n\"The rules are simple enough to write on a train ticket – each turn you either draw more cards, claim a route, or get additional Destination Tickets,\" says Ticket to Ride author, Alan R. Moon. \"The tension comes from being forced to balance greed – adding more cards to your hand, and fear – losing a critical route to a competitor.\"\r\n\r\nTicket to Ride continues in the tradition of Days of Wonder's big format board games featuring high-quality illustrations and components including: an oversize board map of North America, 225 custom-molded train cars, 144 illustrated cards, and wooden scoring markers."
		});
		base.OnModelCreating(modelBuilder);
	}
}
