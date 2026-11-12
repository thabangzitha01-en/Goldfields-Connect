using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldfieldsConnect.Controllers
{
    [Authorize]
    public class AssignmentController : Controller
    {
        [Authorize(Roles = "Student")]
        public IActionResult MyAssignments() => View();

        [Authorize(Roles = "Student")]
        public IActionResult Submit(int id) => View();

        [Authorize(Roles = "Lecturer,HOD")]
        public IActionResult Create() => View();

        [Authorize(Roles = "Lecturer,HOD")]
        public IActionResult Submissions(int id) => View(); // Mark student work
    }
}