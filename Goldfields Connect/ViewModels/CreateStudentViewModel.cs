using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace GoldfieldsConnect.ViewModels
{
    public class CreateStudentViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Programme")]
        public int ProgrammeId { get; set; }

        // Used to populate the dropdown list in the View
        public IEnumerable<SelectListItem>? ProgrammesList { get; set; }
    }
}