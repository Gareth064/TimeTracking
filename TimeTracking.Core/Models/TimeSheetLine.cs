namespace TimeTracking.Core.Models
{
    public class TimeSheetLine
    {
        public Guid Id { get; set; } = new Guid();
        public ActivityType Activity { get; set; }
        public Project Project { get; set; }
        public decimal EstimatedHours { get; set; }
        public decimal ActualHours { get; set; }
        public string Note { get; set; }
    }
}
