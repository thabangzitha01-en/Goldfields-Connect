using GoldfieldsConnect.Models;

namespace GoldfieldsConnect.ViewModels
{
    public class SubjectDetailsViewModel
    {
        public Subject Subject { get; set; } = null!;
        public string LecturerName { get; set; } = string.Empty;

        public List<LearningMaterial> Materials { get; set; } = new List<LearningMaterial>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<Announcement> Announcements { get; set; } = new List<Announcement>();
    }
}