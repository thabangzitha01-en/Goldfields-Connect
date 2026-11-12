using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldfieldsConnect.Controllers
{
    [Authorize]
    public class CommunicationController : Controller
    {
        public IActionResult Announcements() => View();

        [Authorize(Roles = "SystemAdmin,AcademicAdmin,Lecturer")]
        public IActionResult CreateAnnouncement() => View();

        public IActionResult Messages() => View();
        public IActionResult Forums() => View();
    }
}