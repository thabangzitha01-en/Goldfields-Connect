using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldfieldsConnect.Controllers
{
    [Authorize(Roles = "SystemAdmin")]
    public class UserController : Controller
    {
        public IActionResult Index() => View(); // List all users
        public IActionResult Roles() => View(); // Manage roles and permissions
        public IActionResult AuditLogs() => View(); // View system activity
        public IActionResult Settings() => View(); // System settings
    }
}