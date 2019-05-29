using Microsoft.AspNetCore.Mvc;

namespace Library2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Error()
        {
            return View();
        }
    }
}
