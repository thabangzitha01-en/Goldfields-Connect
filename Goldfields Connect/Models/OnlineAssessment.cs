using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldfieldsConnect.Models
{
    public class OnlineAssessment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }

        public int TimeLimitMinutes { get; set; } // This powers your JavaScript Timer
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TotalMarks { get; set; }

        public ICollection<AssessmentQuestion> Questions { get; set; } = new List<AssessmentQuestion>();
    }

    public class AssessmentQuestion
    {
        [Key]
        public int Id { get; set; }

        public int OnlineAssessmentId { get; set; }
        [ForeignKey("OnlineAssessmentId")]
        public OnlineAssessment? Assessment { get; set; }

        [Required]
        public string QuestionText { get; set; } = string.Empty;

        // MultipleChoice, TrueFalse, ShortAnswer, Essay
        public string QuestionType { get; set; } = "MultipleChoice";

        public string? OptionA { get; set; }
        public string? OptionB { get; set; }
        public string? OptionC { get; set; }
        public string? OptionD { get; set; }

        public string? CorrectAnswer { get; set; } // Hidden from students
        public int Marks { get; set; } = 1;
    }
}