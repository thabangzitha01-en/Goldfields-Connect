namespace GoldfieldsConnect.ViewModels
{
    public class DashboardViewModel
    {
        // --- Admin Stats ---
        public int TotalStudents { get; set; }
        public int TotalLecturers { get; set; }
        public int TotalProgrammes { get; set; }
        public int TotalSubjects { get; set; }

        // --- Student Stats ---
        public int MyEnrolledSubjects { get; set; }
        public int PendingAssignments { get; set; }

        // --- Lecturer Stats ---
        public int MyAssignedSubjects { get; set; }
        public int SubmissionsAwaitingMarking { get; set; }

        // --- Shared Data ---
        public string UserFirstName { get; set; } = string.Empty;
        public string RoleName { get; set; } = string.Empty;

        // We can add recent activities or announcements here later
        public List<string> RecentActivities { get; set; } = new List<string>();
    }
}