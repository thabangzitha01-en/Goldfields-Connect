using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldfieldsConnect.Controllers
{
    [Authorize]
    public class AttendanceController : Controller
    {
        [Authorize(Roles = "Lecturer,HOD")]
        public IActionResult Record(int subjectId) => View();

        [Authorize(Roles = "Student")]
        public IActionResult MyAttendance() => View();
    }
}