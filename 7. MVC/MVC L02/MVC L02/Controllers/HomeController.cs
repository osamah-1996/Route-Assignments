using Microsoft.AspNetCore.Mvc;

namespace MVCLect02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //return View("ViewName");
            //return View(new Movie());  // with data
            //return View("viewName", new Movie()); 
        }
    }
}
