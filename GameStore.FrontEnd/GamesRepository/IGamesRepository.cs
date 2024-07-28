using GameStore.FrontEnd.Models;

namespace GameStore.FrontEnd.GamesRepository
{
	public interface IGamesRepository
	{
		public List<GameDetails> GetAllGames();
	}
}
