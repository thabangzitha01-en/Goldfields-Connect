using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldfieldsConnect.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string Code { get; set; } = string.Empty; // e.g., "IT101"

        public int Credits { get; set; }

        public int ProgrammeId { get; set; }
        [ForeignKey("ProgrammeId")]
        public Programme? Programme { get; set; }
    }
}