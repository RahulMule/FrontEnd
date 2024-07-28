namespace GameStore.FrontEnd.Models
{
	public class GameDetails
	{
		public int Id { get; set; }
		public required string Name { get; set; }
		public required string Description { get; set; }
		public required string Genre { get; set; }
        public decimal Price { get; set; }

    }
}
