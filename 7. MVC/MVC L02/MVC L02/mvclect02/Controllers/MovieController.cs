using Microsoft.AspNetCore.Mvc;

namespace MVCLect02.Controllers
{
    public class MoviesController : Controller
    {
        public string Index()
        {
            return "Hello From Index";
        }

        // baseUrl/Movies/GetMovies/10
        [HttpGet]  // defualt and only undertandable by browser
        public IActionResult GetMovies(int? id, string name) // either to pass the par inside the routing in side program
                                                   // Or we pass them as query string, id only in routing
        {                                          // and other attributes as query string [http://localhost:5133/Movies/GetMovies/10?Name=Film]
            //return $"Movie with name {name} and ID {id}";
            if (id == 0)
            {
                return BadRequest();
            }
            else if (id < 10)
            {
                return NotFound();
            }
            else
            {
                return Content($"Movie with name {name} and ID {id}");
            } 
        }

        public IActionResult TestRedirction()
        {
            //return Redirect("https://drive.google.com/drive/folders/17Rs9KUGrcOHX_6-UEmBrZCKoc2nlPxHS"); // will redirect to this site, but to make auto redirect we use
            return RedirectToAction("GetMovies", controllerName:"Movies", routeValues:new {Id=10,name="test"});
        }

        public IActionResult AddMovie(Movie movie)
        {
            return Content(""); 
        }

        public IActionResult AddMovies(string Title, Movie movie, int Id, int[] numbers) // Mixed
        {
            return Content("");
        }
    }
}
