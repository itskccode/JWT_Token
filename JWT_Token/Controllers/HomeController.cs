using Microsoft.AspNetCore.Mvc;

namespace JWT_Token.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
