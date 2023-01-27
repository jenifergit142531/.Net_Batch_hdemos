using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace week8day4.Controllers
{
    public class MemorController : Controller
    {
        private readonly IMemoryCache memory;

        public MemorController(IMemoryCache memory)
        {
            this.memory = memory;
        }

        public IActionResult Index()
        {
            DateTime currenttime;

            bool isExist = memory.TryGetValue("cachetime", out currenttime);
            if(!isExist)
            {
                currenttime = DateTime.Now;
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromSeconds(20));
                memory.Set("cachetime", currenttime, cacheEntryOptions);
            }
            ViewBag.time = currenttime;
            return View();

        }
    }
}
