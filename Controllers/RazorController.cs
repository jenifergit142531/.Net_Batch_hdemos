using Microsoft.AspNetCore.Mvc;

namespace Week8Day1.Controllers
{
    public class RazorController : Controller
    {
        [Route("View")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
