using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldfieldsConnect.Models
{
    public class Enrolment
    {
        [Key]
        public int Id { get; set; }

        public int StudentProfileId { get; set; }
        [ForeignKey("StudentProfileId")]
        public StudentProfile? Student { get; set; }

        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }

        public DateTime EnrolmentDate { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Enrolled"; // Enrolled, Dropped, Completed
    }
}