using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using Tranfer_date_Controller_to_Modle.Models;

namespace Tranfer_date_Controller_to_Modle.Controllers
{
    public class Moviess : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

         
           
            return View();
        }

        [HttpPost]
        public IActionResult Index(movie mv )
        {

            ViewBag.id = mv.Id;
            ViewBag.title = mv.Title;
            ViewBag.description = mv.Description;

            return View();
        }
    }
}
