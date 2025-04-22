using AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace firstMvcLect.Controllers
{
    public class Students : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {

            int num1 = 40;
            int num2 = 75;
            int result = num1+num2;

            ViewBag.sum=result;
            ViewBag.salary = "400k";
            return View("nahe");
        }


        public IActionResult testPage()
        {
            return Content("Thank You For Visiting");
        }

        public IActionResult Details()
        {
            int abc = 90;
            if (abc == null)
                return Views();
            return NotFound();
        }

    }
}
