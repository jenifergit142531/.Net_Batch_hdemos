using Azure.Identity;
using Microsoft.AspNetCore.Mvc;

namespace week8day3.Controllers
{
    public class CookieController : Controller
    {
        private string UserName;


        [HttpGet]
        public IActionResult Index()
        {
            UserName = Request.Cookies["UserName"];
            return View("Index", UserName);
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            UserName = form["UserName"].ToString();
            CookieOptions newCookie = new CookieOptions();
            newCookie.Expires = DateTime.Now.AddSeconds(5);
            Response.Cookies.Append("UserName", UserName);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult RemoveCookie()
        {
            Response.Cookies.Delete("UserName");
            return View("Index");
        }

    }
}
