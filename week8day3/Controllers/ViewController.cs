using Microsoft.AspNetCore.Mvc;
using week8day3.Models;

namespace week8day3.Controllers
{
    public class ViewController : Controller
    {
        public IActionResult Index()
        {
            //complex data - object

            Purchase items = new Purchase()
            {
                PurchaseId = 101,
                ProductName="Mackbook pro",
                NumberOfItems = 10,
                Address="chennai",
                Email="jjj@gmail.com",
                PhoneNumber="1234567"
            };


            //simple data 

            string message = "VIEW STATE ";


            //syntax for viewbag
            ViewBag.Items = items;

            //syntax for viewdata

            ViewData["title"] = message;
                
            

            //temp data - pass the data from one controller action to another action method
            TempData["message"] = "This is a temp data example";

            return View();
        }

        public string Tempmessage()
        {
            return TempData["message"].ToString();
        }
    }
}
