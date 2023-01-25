using Microsoft.AspNetCore.Mvc;
using week8day3.Models;

namespace week8day3.Controllers
{
    public class PurchaseController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Check()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Check(Purchase p)
        {
          
            if(!ModelState.IsValid)
            {
                return Content("Error");
            }
            else
            {
               return Content("purchase is successfull");
            }

            


        }
    }
}
