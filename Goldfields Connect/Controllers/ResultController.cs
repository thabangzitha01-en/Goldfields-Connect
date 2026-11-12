using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldfieldsConnect.Controllers
{
    [Authorize]
    public class ResultController : Controller
    {
        [Authorize(Roles = "Lecturer")]
        public IActionResult CaptureMarks(int subjectId) => View();

        [Authorize(Roles = "HOD")]
        public IActionResult Moderate() => View();

        [Authorize(Roles = "AcademicAdmin")]
        public IActionResult ApproveAndPublish() => View();

        [Authorize(Roles = "Student")]
        public IActionResult MyResults() => View();
    }
}