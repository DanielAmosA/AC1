using ServerSide1.BL;

namespace ServerSide1.Orc
{
    /// <summary>
    /// The GamesOrcRead class responsible for Managing Read requests 
    /// From the GamesController (API) to the GamesBL (Business Logic).
    /// </summary>
    /// 
    public class GamesOrcRead
    {
        private readonly GamesBL gamesBL;

        public GamesOrcRead(GamesBL gamesBL)
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
