using Microsoft.AspNetCore.Mvc;

namespace Week8Day1.Controllers
{
    public class HelperController : Controller
    {
       // [Route("Form")]
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ContentResult UserRegistration()
        {
            return Content(
                "USERNAME :" + Request.Form["username"] +
                "EMAIL ID :" + Request.Form["email"]+
                "GENDER :" + Request.Form["Gender"]+
                "Courses :" + Request.Form["courses"]
               

                );
        }
    }
}
