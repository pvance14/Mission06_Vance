using Microsoft.AspNetCore.Mvc;
using Mission06_Vance.Models;
using System.Diagnostics;

namespace Mission06_Vance.Controllers
{
    public class HomeController : Controller
    {
        private NewMoviesContext _context;

        public HomeController(NewMoviesContext temp) //constructor
        { 
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetToKnowJoe()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewMovie()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList(); 
                
            return View("NewMovie");
        }

        [HttpPost]
        public IActionResult NewMovie(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); //add record to the database
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.CategoryName)
                    .ToList();

                return View(response);
            }

        }

        public IActionResult Collection () // this takes us to the view with the table of movies
        {
            // linq query
            var movies = _context.Movies
                .OrderBy(x => x.Title).ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id) // this makes our edit button return the right record
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View("NewMovie", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo) // this makes sure that our edits are saved
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("Collection"); // this makes sure the collection view is properly shown
        }

        public IActionResult Delete()
        {

        }
    }
}
