using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldfieldsConnect.Models
{
    public class Assignment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;

        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }

        public DateTime DueDate { get; set; }
        public int MaxMarks { get; set; }
    }
}