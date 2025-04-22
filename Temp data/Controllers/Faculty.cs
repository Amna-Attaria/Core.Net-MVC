using Microsoft.AspNetCore.Mvc;

namespace Temp_data.Controllers
{
    public class Faculty : Controller
    {
        public IActionResult Index()
        {
            TempData.Keep("empcount");
            return View();
        }

        public IActionResult About()
        {
            TempData["empcount"] = 90;
            TempData.Keep("empcount");
            return View();
        }
    }
}
