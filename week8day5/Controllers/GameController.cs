using Microsoft.AspNetCore.Mvc;
using week8day5.Models;

namespace week8day5.Controllers
{
    public class GameController : Controller
    {
        private readonly IPlayerGenerator _playerGenerator;
        private readonly IAllPlayers _allPlayers;
        public GameController(IPlayerGenerator playerGenerator,IAllPlayers allPlayers)
        {
            _playerGenerator = playerGenerator;
            _allPlayers = allPlayers;
        }

        public IActionResult Index()
        {
            //object 1 with class1 - tightly coupled code 
            // var playerGenerator = new AllPlayerGenerator();

            var newPlayer = _allPlayers.CreateNewPlayer();
            return Ok(newPlayer);
            
        }

        public IActionResult showMessage()
        {
            var message = _allPlayers.AllPlayerMessage();
            return Ok(message);

        }

        public IActionResult show()
        {
            //object 2 with class2 - tightly coupled code 

           // var chessPlayerGenerator = new ChessPlayerGenerator();

            var chessPlayer = _playerGenerator.CreateChessPlayers();
            return Ok(chessPlayer);

        }


    }
}
