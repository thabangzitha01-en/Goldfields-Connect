using GoldfieldsConnect.Database;
using GoldfieldsConnect.Services;
using GoldfieldsConnect.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace GoldfieldsConnect.Controllers
{
    public class AuthController : Controller
    {
        private readonly SupabaseService _supabase;
        private readonly ApplicationDbContext _context; // Added DB Context

        public AuthController(SupabaseService supabase, ApplicationDbContext context)
        {
            _supabase = supabase;
            _context = context;
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            try
            {
                var session = await _supabase.Client.Auth.SignIn(model.Email, model.Password);
                if (session?.User != null)
                {
                    // Get the user from the database to find their actual role
                    var userProfile = await _context.UserProfiles.FirstOrDefaultAsync(u => u.Email == model.Email);
                    string role = userProfile?.Role ?? "Student";

                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, session.User.Id ?? string.Empty),
                        new Claim(ClaimTypes.Email, session.User.Email ?? string.Empty),
                        new Claim(ClaimTypes.Name, $"{userProfile?.FirstName ?? "User"} {userProfile?.LastName ?? ""}"),
                        new Claim(ClaimTypes.Role, role)
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                    return RedirectToAction("Index", "Dashboard");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Login failed: " + ex.Message);
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _supabase.Client.Auth.SignOut();
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Auth");
        }

        public IActionResult AccessDenied() => View();
    }
}