using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace GoldfieldsConnect.ViewModels
{
    public class ReportFilterViewModel
    {
        [Display(Name = "Report Type")]
        public string ReportType { get; set; } = string.Empty; // e.g., "Student List", "Attendance", "Results"

        [Display(Name = "Department")]
        public int? DepartmentId { get; set; }

        [Display(Name = "Programme")]
        public int? ProgrammeId { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        // Dropdowns for the UI
        public IEnumerable<SelectListItem>? DepartmentsList { get; set; }
        public IEnumerable<SelectListItem>? ProgrammesList { get; set; }
    }
}