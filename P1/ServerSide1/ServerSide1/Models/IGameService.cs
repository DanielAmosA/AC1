namespace ServerSide1.Models
{
    public interface IGameService
    {
        List<Game> GetGames();
        Game AddGame(Game game);
        Game UpdateGame(Game game);
        void DeleteGame(int id);
    }
}
