using GoldfieldsConnect.Database;
using GoldfieldsConnect.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace GoldfieldsConnect.Controllers
{
    [Authorize(Roles = "SystemAdmin,AcademicAdmin,HOD,Student")] // Added Student
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ... (Keep your existing Index, Create, Details, Edit methods here) ...

        // NEW: View and Edit Profile
        [Authorize(Roles = "Student")]
        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            // Get logged-in user's ID
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var student = await _context.StudentProfiles
                .Include(s => s.User)
                .Include(s => s.Programme)
                .FirstOrDefaultAsync(s => s.UserId == Guid.Parse(userId!));

            if (student == null) return NotFound("Student profile not found.");

            var model = new StudentProfileViewModel
            {
                FirstName = student.User?.FirstName ?? "",
                LastName = student.User?.LastName ?? "",
                Email = student.User?.Email ?? "",
                StudentNumber = student.StudentNumber,
                ProgrammeName = student.Programme?.Name ?? "Not Assigned",
                PhoneNumber = "" // Add to UserProfile model if needed later
            };

            return View(model);
        }

        [Authorize(Roles = "Student")]
        [HttpPost]
        public async Task<IActionResult> Profile(StudentProfileViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userProfile = await _context.UserProfiles.FindAsync(Guid.Parse(userId!));

            if (userProfile != null)
            {
                userProfile.FirstName = model.FirstName;
                userProfile.LastName = model.LastName;
                // Do not update Email here, that requires Supabase Auth handling

                _context.UserProfiles.Update(userProfile);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Profile updated successfully!";
                return RedirectToAction(nameof(Profile));
            }

            return View(model);
        }
    }
}