using ServerSide1.BL;

namespace ServerSide1.Orc
{
    /// <summary>
    /// The GamesOrcWrite class responsible for Managing Write requests 
    /// From the GamesController (API) to the GamesBL (Business Logic).
    /// </summary>
    public class GamesOrcWrite
    {
        private readonly GamesBL gamesBL;

        public GamesOrcWrite(GamesBL gamesBL)
        {
            // Calling and executing services of the BL (Business Logic).
            this.gamesBL = gamesBL;
        }
        //public async Task<string?> GetThePasswordByEmail(string email)
        //{
        //    return await gamesBL.GetThePasswordByEmail(email);
        //}
    }
}
