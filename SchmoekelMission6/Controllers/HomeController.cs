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

        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.Categories = _context.Categories.ToList();

            return View("Movies");
        }


        [HttpPost]
        public IActionResult Movies(Movie response) 
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Movie", response);
        }

        public IActionResult TableView()
        {
            // Retrieve movies from the database
            var movies = _context.Movies.ToList();

            // Pass the movies to the view
            return View(movies);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);
            ViewBag.Categories = _context.Categories.ToList();

            return View("Movies", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo) 
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
            return RedirectToAction("TableView");
        }

        [HttpPost]
        public IActionResult Delete(Movie movie) 
        { 
             _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("TableView");

        }

    }
}
