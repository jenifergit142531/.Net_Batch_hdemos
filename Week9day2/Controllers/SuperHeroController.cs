using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week9day2.Models;

namespace Week9day2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        IList<SuperHeroes> hero = new List<SuperHeroes>()
        {
            new SuperHeroes()
            {
                CartoonId=100,
                HeroName="Iron man",
                CartoonName="Avengers",
                Viewers=1200
                
            },
            new SuperHeroes()
            {
                CartoonId=200,
                HeroName="Shinchan",
                CartoonName="Shinchan",
                Viewers=5000

            },
            new SuperHeroes()
            {
                CartoonId=300,
                HeroName="Bheem",
                CartoonName="chota Bheem",
                Viewers=700

            },
            new SuperHeroes()
            {
                CartoonId=400,
                HeroName="Tom",
                CartoonName="Tom & Jerry",
                Viewers=7000

            },


        };

        [HttpGet]
        [Route ("getall")]
        public IList<SuperHeroes> GetHeroes()
        {
            return hero;
        }

        [HttpGet]
        [Route("getid/{id}")]
        public SuperHeroes GetHeroesById(int id)
        {
            SuperHeroes h = hero.FirstOrDefault(e => e.CartoonId == id);
            if(hero==null)
            {
                throw new NotImplementedException();
            }
            return h;
        }
    }
}
