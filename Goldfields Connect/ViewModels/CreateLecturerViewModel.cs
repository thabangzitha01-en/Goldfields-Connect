using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace GoldfieldsConnect.ViewModels
{
    public class CreateLecturerViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Staff Number")]
        public string StaffNumber { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        // Dropdown list for Departments
        public IEnumerable<SelectListItem>? DepartmentsList { get; set; }
    }
}