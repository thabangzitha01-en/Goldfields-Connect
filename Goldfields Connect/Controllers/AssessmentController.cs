using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldfieldsConnect.Controllers
{
    [Authorize]
    public class AssessmentController : Controller
    {
        [Authorize(Roles = "Lecturer,HOD")]
        public IActionResult QuestionBank() => View();

        [Authorize(Roles = "Lecturer,HOD")]
        public IActionResult Create() => View();

        [Authorize(Roles = "Student")]
        public IActionResult TakeAssessment(int id)
        {
            // TODO: Pass the TimeLimit (in seconds) to the View via ViewBag for the JS Timer
            ViewBag.TimeLimit = 3600;
            return View();
        }
    }
}   