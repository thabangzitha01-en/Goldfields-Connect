using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldfieldsConnect.Controllers
{
    [Authorize(Roles = "SystemAdmin,AcademicAdmin,HOD")]
    public class LecturerController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Create() => View();
        public IActionResult Allocations() => View(); // Manage subject allocations
    }
}