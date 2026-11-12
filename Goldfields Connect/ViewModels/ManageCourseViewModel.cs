using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace GoldfieldsConnect.ViewModels
{
    public class ManageCourseViewModel
    {
        [Required]
        [Display(Name = "Course Code")]
        public string Code { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Course Name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int Credits { get; set; }

        [Required]
        [Display(Name = "Programme")]
        public int ProgrammeId { get; set; }

        // Dropdown list for Programmes
        public IEnumerable<SelectListItem>? ProgrammesList { get; set; }
    }
}