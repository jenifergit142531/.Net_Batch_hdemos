using Microsoft.AspNetCore.Mvc;
using Week8Day1.Models;

namespace Week8Day1.Controllers
{
    public class GameController : Controller
    {
        //   [Route("mygame/Gamer")]
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {

            Gaming[] game = new Gaming[]
            {
                new Gaming
                {
                    GameId=1001,
                    GameName="Snake&Ladder",
                    GameType="Single Player",
                    PlayersCount=1,
                    Score=2500
                },new Gaming
                {
                    GameId=1002,
                    GameName="Hockey",
                    GameType="Multi Player",
                    PlayersCount=5,
                    Score=500
                },
                new Gaming
                {
                    GameId=1003,
                    GameName="PUBG",
                    GameType="Multi Player",
                    PlayersCount=70,
                    Score=5500
                }

            };


            return View(game);
        }



        
    }
}
