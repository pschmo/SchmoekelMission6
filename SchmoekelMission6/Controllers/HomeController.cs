using Microsoft.AspNetCore.Mvc;
using SchmoekelMission6.Models;
using System.Diagnostics;

namespace SchmoekelMission6.Controllers
{
    public class HomeController : Controller
    {   
        private MovieContext _context;
        public HomeController(MovieContext temp) 
        { 
            _context = temp;
        }
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

        public IActionResult Submission()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Movies(Submission response) 
        {
            _context.Submission.Add(response);
            _context.SaveChanges();

            return View();
        }

    }
}
