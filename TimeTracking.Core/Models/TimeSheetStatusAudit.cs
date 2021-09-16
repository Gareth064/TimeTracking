namespace TimeTracking.Core.Models
{
public class TimeSheetStatusAudit
    {
        public Guid Id { get; set; } = new Guid();
        public TimeSheetHeader TimeSheet { get; set; }
        public TimeSheetStatus Status { get; set; }
        public DateTimeOffset ChangedOn { get; set; }
        public Resource ChangedBy { get; set; }
    }
}
