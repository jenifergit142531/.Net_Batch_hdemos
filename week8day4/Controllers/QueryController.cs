using Microsoft.AspNetCore.Mvc;

namespace week8day4.Controllers
{
    public class QueryController : Controller
    {
        public IActionResult Index()
        {
            string name = "test";
            if (!string.IsNullOrEmpty(HttpContext.Request.Query["name"]))
                name = HttpContext.Request.Query["name"];
            return Content("welcome  " + name);
        }

        
    }
}
