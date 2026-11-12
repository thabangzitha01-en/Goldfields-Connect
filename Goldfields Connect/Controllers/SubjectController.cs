using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldfieldsConnect.Controllers
{
    [Authorize]
    public class SubjectController : Controller
    {
        [Authorize(Roles = "SystemAdmin,AcademicAdmin")]
        public IActionResult Index() => View();

        [Authorize(Roles = "SystemAdmin,AcademicAdmin")]
        public IActionResult Create() => View();

        [Authorize(Roles = "Lecturer,HOD,Student")]
        public IActionResult Details(int id) => View(); // View materials, assignments

        [Authorize(Roles = "Lecturer")]
        public IActionResult MySubjects() => View();
    }
}