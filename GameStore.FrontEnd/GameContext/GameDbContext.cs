using GameStore.FrontEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.FrontEnd.GameContext
{
	public class GameDbContext : DbContext
	{
		public GameDbContext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<GameDetails> Games { get; set; }
	}
}
