using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldfieldsConnect.Controllers
{
    [Authorize] // All logged-in users can view the library
    public class LibraryController : Controller
    {
        public IActionResult Index() => View(); // Search and view resources

        [Authorize(Roles = "SystemAdmin,AcademicAdmin")] // Only admins upload
        public IActionResult UploadResource() => View();
    }
}