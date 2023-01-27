using Microsoft.AspNetCore.Mvc;


namespace week8day4.Controllers
{
    public class CacheController : Controller
    {
        [OutputCache]
            
        public IActionResult Index()
        {
            ViewBag.Message = DateTime.Now.ToString();
            return View();
        }
    }
}
