using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldfieldsConnect.Controllers
{
    [Authorize]
    public class TimetableController : Controller
    {
        public IActionResult Index() => View(); // View personal timetable

        [Authorize(Roles = "AcademicAdmin,SystemAdmin")]
        public IActionResult ManageRooms() => View();

        [Authorize(Roles = "AcademicAdmin,SystemAdmin")]
        public IActionResult Schedule() => View();
    }
}