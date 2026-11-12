using System.ComponentModel.DataAnnotations;

namespace GoldfieldsConnect.Models
{
    public class UserProfile
    {
        [Key]
        public Guid Id { get; set; } // MUST match the Supabase Auth User ID

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        // Roles: SystemAdmin, AcademicAdmin, HOD, Lecturer, Student
        [Required]
        public string Role { get; set; } = "Student";

        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}