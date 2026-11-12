using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldfieldsConnect.Models
{
    public class Attendance
    {
        [Key]
        public int Id { get; set; }

        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }

        public int StudentProfileId { get; set; }
        [ForeignKey("StudentProfileId")]
        public StudentProfile? Student { get; set; }

        public DateTime ClassDate { get; set; }

        // Present, Absent, Late, Excused
        public string Status { get; set; } = "Present";
    }
}