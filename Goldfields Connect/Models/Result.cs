using GoldfieldsConnect.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldfieldsConnect.Models
{
    public class Result
    {
        [Key]
        public int Id { get; set; }

        public int StudentProfileId { get; set; }
        [ForeignKey("StudentProfileId")]
        public StudentProfile? Student { get; set; }

        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }

        public double FinalMark { get; set; }
        public string Grade { get; set; } = string.Empty; // A, B, C, Distinction, etc.

        // Pending, Moderated, Approved, Published
        public string Status { get; set; } = "Pending";

        public DateTime? PublishedAt { get; set; }
    }
}