using Microsoft.AspNetCore.Mvc;
using SchmoekelMission6.Models;
using System.Diagnostics;

namespace SchmoekelMission6.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Movies()
        {
            return View();
        }


    }
}
