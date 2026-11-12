using System.ComponentModel.DataAnnotations;

namespace GoldfieldsConnect.ViewModels
{
    public class StudentProfileViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; } = string.Empty; // Read-only usually

        [Display(Name = "Programme")]
        public string ProgrammeName { get; set; } = string.Empty; // Read-only

        [Phone]
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }
    }
}