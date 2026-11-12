using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldfieldsConnect.Models
{
    public class LearningMaterial
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }

        public string FileUrl { get; set; } = string.Empty; // Supabase Storage URL
        public string FileType { get; set; } = string.Empty; // PDF, Video, PPT

        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
    }
}