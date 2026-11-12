using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldfieldsConnect.Controllers
{
    [Authorize(Roles = "SystemAdmin,AcademicAdmin,HOD")]
    public class ExaminationController : Controller
    {
        public IActionResult Index() => View(); // List exam sessions
        public IActionResult Timetable() => View(); // Exam schedule
        public IActionResult Venues() => View(); // Manage exam rooms
        public IActionResult Invigilators() => View(); // Allocate staff
    }
}