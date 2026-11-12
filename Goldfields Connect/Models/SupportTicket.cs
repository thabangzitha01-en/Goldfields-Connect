using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldfieldsConnect.Models
{
    public class SupportTicket
    {
        [Key]
        public int Id { get; set; }

        public Guid StudentId { get; set; }
        [ForeignKey("StudentId")]
        public UserProfile? Student { get; set; }

        [Required]
        public string Subject { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public string Status { get; set; } = "Open"; // Open, In Progress, Resolved
        public string? AdminResponse { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}