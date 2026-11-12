using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldfieldsConnect.Controllers
{
    [Authorize]
    public class SupportController : Controller
    {
        [Authorize(Roles = "Student")]
        public IActionResult SubmitTicket() => View();

        public IActionResult MyTickets() => View();

        [Authorize(Roles = "SystemAdmin,AcademicAdmin")]
        public IActionResult ManageTickets() => View();
    }
}