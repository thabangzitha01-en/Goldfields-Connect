using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldfieldsConnect.Models
{
    public class Examination
    {
        [Key]
        public int Id { get; set; }

        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }

        public DateTime ExamDate { get; set; }

        public int RoomId { get; set; }
        [ForeignKey("RoomId")]
        public Room? Room { get; set; }

        public Guid InvigilatorId { get; set; }
        [ForeignKey("InvigilatorId")]
        public UserProfile? Invigilator { get; set; }
    }
}