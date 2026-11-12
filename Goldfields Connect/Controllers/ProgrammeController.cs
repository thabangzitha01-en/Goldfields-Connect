using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldfieldsConnect.Controllers
{
    [Authorize(Roles = "SystemAdmin,AcademicAdmin")]
    public class ProgrammeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Create() => View();
        public IActionResult Structure(int id) => View(); // Link subjects to programmes
    }
}