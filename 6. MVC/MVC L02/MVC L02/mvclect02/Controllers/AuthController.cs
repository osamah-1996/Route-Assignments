using Microsoft.AspNetCore.Mvc;

namespace mvclect02.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult SingIn()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
