using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldfieldsConnect.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            // Route System Admin and Academic Admin separately
            if (User.IsInRole("SystemAdmin")) return RedirectToAction("AdminDashboard");
            if (User.IsInRole("AcademicAdmin")) return RedirectToAction("AcademicDashboard");

            if (User.IsInRole("HOD")) return RedirectToAction("HodDashboard");
            if (User.IsInRole("Lecturer")) return RedirectToAction("LecturerDashboard");
            if (User.IsInRole("Student")) return RedirectToAction("StudentDashboard");

            return RedirectToAction("Login", "Auth");
        }

        [Authorize(Roles = "SystemAdmin")]
        public IActionResult AdminDashboard() => View();

        [Authorize(Roles = "AcademicAdmin")]
        public IActionResult AcademicDashboard() => View();

        [Authorize(Roles = "HOD")]
        public IActionResult HodDashboard() => View();

        [Authorize(Roles = "Lecturer")]
        public IActionResult LecturerDashboard() => View();

        [Authorize(Roles = "Student")]
        public IActionResult StudentDashboard() => View();
    }
}