using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldfieldsConnect.Models
{
    public class LecturerProfile
    {
        [Key]
        public int Id { get; set; }

        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public UserProfile? User { get; set; }

        [Required]
        [StringLength(20)]
        public string StaffNumber { get; set; } = string.Empty;

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }
    }
}