using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldfieldsConnect.Controllers
{
    [Authorize(Roles = "SystemAdmin,AcademicAdmin")]
    public class DepartmentController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Create() => View();
    }
}