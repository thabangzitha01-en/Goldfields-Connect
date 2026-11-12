using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace GoldfieldsConnect.ViewModels
{
    public class SubmitAssignmentViewModel
    {
        public int AssignmentId { get; set; }

        public string AssignmentTitle { get; set; } = string.Empty;

        [Display(Name = "Upload File (PDF, Word, etc.)")]
        public IFormFile? SubmissionFile { get; set; } // Handles the file upload

        [Display(Name = "Or type your answer here")]
        public string? TextSubmission { get; set; }
    }
}