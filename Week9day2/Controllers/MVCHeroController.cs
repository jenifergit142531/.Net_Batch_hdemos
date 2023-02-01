using Microsoft.AspNetCore.Mvc;
using Week9day2.Models;

namespace Week9day2.Controllers
{
    public class MVCHeroController : Controller
    {

        IEnumerable<SuperHeroes> supers = null;
        public IActionResult Index()
        {
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://localhost:44333/api/");
                var responseTask = client.GetAsync("superhero");
                responseTask.Wait();
                var result = responseTask.Result;

                Task<string> readTask = result.Content.ReadAsAsync<IList<SuperHeroes>>();
                 readTask.Wait();
                supers = readTask.Result;
                
            }
            return Ok(supers);
        }
    }
}
