using GoldfieldsConnect.Models;

namespace GoldfieldsConnect.ViewModels
{
    public class StudentGradesViewModel
    {
        public string StudentNumber { get; set; } = string.Empty;
        public string ProgrammeName { get; set; } = string.Empty;

        // Only results that have been published (Status == "Published")
        public List<Result> PublishedResults { get; set; } = new List<Result>();

        public double AverageMark => PublishedResults.Any() ? PublishedResults.Average(r => r.FinalMark) : 0;
    }
}