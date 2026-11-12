using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldfieldsConnect.Models
{
    public class StudentProfile
    {
        [Key]
        public int Id { get; set; }

        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public UserProfile? User { get; set; }

        [Required]
        [StringLength(20)]
        public string StudentNumber { get; set; } = string.Empty;

        public int ProgrammeId { get; set; }
        [ForeignKey("ProgrammeId")]
        public Programme? Programme { get; set; }

        public string Status { get; set; } = "Active"; // Active, Suspended, Withdrawn, Completed
    }
}