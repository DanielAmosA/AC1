using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerSide1.Models;
using ServerSide1.Orc;

namespace ServerSide1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        private readonly GamesOrcRead gamesOrcRead;
        private readonly GamesOrcWrite gamesOrcWrite;

        public GameController(IGameService gameService, GamesOrcRead gamesOrcRead , GamesOrcWrite gamesOrcWrite )
        {
            _gameService = gameService;
            this.gamesOrcRead = gamesOrcRead;
            this.gamesOrcWrite = gamesOrcWrite;
        }

        [HttpGet]
        //public IActionResult Get() => Ok(_gameService.GetGames());
        public IActionResult Get()
        {
            //string? password = await employeeOrcRead.GetThePasswordByEmail(email);
            //if (password == null)
            //{
            //    throw new NotFoundException($"Employee with Email {email} not found");
            //}
            //return Ok(password);
            return Ok(_gameService.GetGames());
        }

        [HttpPost]
        public IActionResult Post(Game game) => Ok(_gameService.AddGame(game));

        [HttpPut("{id}")]
        public IActionResult Put(int id, Game game)
        {
            if (id != game.Id) return BadRequest();
            return Ok(_gameService.UpdateGame(game));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _gameService.DeleteGame(id);
            return NoContent();
        }
    }
}
