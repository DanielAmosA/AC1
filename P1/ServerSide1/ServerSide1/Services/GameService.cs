using ServerSide1.Models;

namespace ServerSide1.Services
{
    public class GameService : IGameService
    {
        private readonly List<Game> _games;

        public GameService()
        {
            _games = new List<Game>
        {
            new Game { Id = 1, Name = "The Witcher 3", Genre = "RPG", Price = 49.99M },
            new Game { Id = 2, Name = "Cyberpunk 2077", Genre = "RPG", Price = 59.99M }
        };
        }

        public List<Game> GetGames() => _games;

        public Game AddGame(Game game)
        {
            game.Id = _games.Max(g => g.Id) + 1;
            _games.Add(game);
            return game;
        }

        public Game UpdateGame(Game game)
        {
            var existingGame = _games.FirstOrDefault(g => g.Id == game.Id);
            if (existingGame != null)
            {
                existingGame.Name = game.Name;
                existingGame.Genre = game.Genre;
                existingGame.Price = game.Price;
            }
            return existingGame;
        }

        public void DeleteGame(int id)
        {
            var game = _games.FirstOrDefault(g => g.Id == id);
            if (game != null)
            {
                _games.Remove(game);
            }
        }
    }
}
