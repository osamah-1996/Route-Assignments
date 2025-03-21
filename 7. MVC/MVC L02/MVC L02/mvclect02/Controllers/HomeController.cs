using Microsoft.AspNetCore.Mvc;

namespace MVCLect02.Controllers
{
    public class HomeController : Controller
    {
        // BaseUrl/Home/Index
        [HttpGet]
        public IActionResult Index()
        {
            return View();
            //return View("ViewName");
            //return View(new Movie());  // with data
            //return View("viewName", new Movie()); 
        }


        // BaseUrl/Home/Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // BaseUrl/Home/AboutUs
        public IActionResult AboutUs()
        {
            return View();
        }

        // BaseUrl/Home/ContactUs
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
