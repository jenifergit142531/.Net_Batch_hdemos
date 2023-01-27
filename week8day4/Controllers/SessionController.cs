using Microsoft.AspNetCore.Mvc;

namespace week8day4.Controllers
{
    public class SessionController : Controller
    {
        const string Name = "_Name";
        const string City = "_City";

        public IActionResult Index()
        {
            HttpContext.Session.SetString(Name, "Jenifer");
            HttpContext.Session.SetString(City, "Chennai");
            return View();
        }

        public IActionResult show()
        {
            ViewBag.Name=HttpContext.Session.GetString(Name);
            ViewBag.City=HttpContext.Session.GetString(City);
            TempData["sessionId"] = HttpContext.Session.Id;
            return View();

        }
    }
}
