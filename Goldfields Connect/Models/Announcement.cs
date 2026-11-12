using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldfieldsConnect.Models
{
    public class Announcement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;

        // Who posted it
        public Guid AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public UserProfile? Author { get; set; }

        // Scope: "College-wide", "Department", "Subject"
        public string TargetAudience { get; set; } = "College-wide";
        public int? TargetId { get; set; } // e.g., DepartmentId or SubjectId

        public DateTime PostedAt { get; set; } = DateTime.UtcNow;
    }
}