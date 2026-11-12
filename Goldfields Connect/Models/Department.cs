using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldfieldsConnect.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        // Foreign Key to UserProfile for the Head of Department
        public Guid? HodId { get; set; }
        [ForeignKey("HodId")]
        public UserProfile? Hod { get; set; }
    }
}