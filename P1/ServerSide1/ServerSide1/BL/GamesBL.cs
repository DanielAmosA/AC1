using ServerSide1.DAL;

namespace ServerSide1.BL
{
    /// <summary>
    /// The GamesBL class responsible for Games Business Logic 
    /// Before being sent to the GamesDAL (Data Access Layer).
    /// </summary>
    public class GamesBL
    {
        private readonly GamesDAL gamesDAL;

        public GamesBL(GamesDAL gamesDAL)
        {
            // Calling and executing services of the DAL (Data Access Layer).
            this.gamesDAL = gamesDAL;
        }

        //public async Task<string?> GetThePasswordByEmail(string email)
        //{
        //    return await gamesDAl.GetThePasswordByEmail(email);
        //}
    }
}
