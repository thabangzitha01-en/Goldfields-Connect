using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldfieldsConnect.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "Lab A", "Room 101"
        public int Capacity { get; set; }
    }

    public class Timetable
    {
        [Key]
        public int Id { get; set; }

        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }

        public int RoomId { get; set; }
        [ForeignKey("RoomId")]
        public Room? Room { get; set; }

        public Guid LecturerId { get; set; } // Link to UserProfile
        [ForeignKey("LecturerId")]
        public UserProfile? Lecturer { get; set; }

        public DayOfWeek DayOfWeek { get; set; } // Monday, Tuesday, etc.
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}