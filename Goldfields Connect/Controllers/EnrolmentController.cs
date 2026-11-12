using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldfieldsConnect.Controllers
{
    [Authorize(Roles = "SystemAdmin,AcademicAdmin")]
    public class EnrolmentController : Controller
    {
        public IActionResult Index() => View(); // View all enrolments
        public IActionResult EnrolStudent() => View();
        public IActionResult Withdrawals() => View();
    }
}