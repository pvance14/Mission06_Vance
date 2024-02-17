using Microsoft.AspNetCore.Mvc;
using Mission06_Vance.Models;
using System.Diagnostics;

namespace Mission06_Vance.Controllers
{
    public class HomeController : Controller
    {
        private NewMoviesContext _context;

        public HomeController(NewMoviesContext temp)
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
            return View("NewMovie");
        }

        [HttpPost]
        public IActionResult NewMovie(Movie response)
        {
            _context.Movies.Add(response); //add record to the database
            _context.SaveChanges();
            
            return View("Confirmation", response);
        }
    }
}
