using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldfieldsConnect.Models
{
    public class AssignmentSubmission
    {
        [Key]
        public int Id { get; set; }

        public int AssignmentId { get; set; }
        [ForeignKey("AssignmentId")]
        public Assignment? Assignment { get; set; }

        public int StudentProfileId { get; set; }
        [ForeignKey("StudentProfileId")]
        public StudentProfile? Student { get; set; }

        public string? FileUrl { get; set; } // Supabase Storage URL
        public string? TextSubmission { get; set; }

        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;

        public int? Mark { get; set; }
        public string? Feedback { get; set; }

        public string Status { get; set; } = "Submitted"; // Submitted, Graded, Late
    }
}