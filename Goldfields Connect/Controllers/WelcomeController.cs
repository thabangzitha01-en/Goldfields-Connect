using Microsoft.AspNetCore.Mvc;

namespace GoldfieldsConnect.Controllers
{
    public class WelcomeController : Controller
    {
        // This is the public landing page (no login required)
        public IActionResult Index()
        {
            return View();
        }
    }
}