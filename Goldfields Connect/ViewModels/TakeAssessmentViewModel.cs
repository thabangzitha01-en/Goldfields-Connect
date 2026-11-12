using GoldfieldsConnect.Models;

namespace GoldfieldsConnect.ViewModels
{
    public class TakeAssessmentViewModel
    {
        public OnlineAssessment Assessment { get; set; } = null!;
        public List<AssessmentQuestion> Questions { get; set; } = new List<AssessmentQuestion>();

        // This is passed to JavaScript to start the countdown
        public int TimeLimitInSeconds { get; set; }
    }
}