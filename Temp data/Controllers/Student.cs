using Microsoft.AspNetCore.Mvc;

namespace Temp_data.Controllers
{
    public class Student : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
