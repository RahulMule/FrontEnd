using GameStore.FrontEnd.GameContext;
using GameStore.FrontEnd.Models;

namespace GameStore.FrontEnd.GamesRepository
{
	public class GameRepository : IGamesRepository
	{
		private readonly GameDbContext _dbContext;
        public GameRepository(GameDbContext _context)
        {
			_dbContext = _context; 
        }
        public List<GameDetails> GetAllGames()
		{
			if (_dbContext.Games.ToList() == null)
			{
				return null;
			}
			return _dbContext.Games.ToList();
			
		}
	}
}
