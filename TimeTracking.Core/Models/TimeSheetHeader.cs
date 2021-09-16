namespace TimeTracking.Core.Models
{
    public class TimeSheetHeader
    {
        public Guid Id { get; set; } = new Guid();
        public Resource Resource { get; set; }
        public DateTimeOffset Date { get; set; }
        public TimeSheetStatus Status { get; set; }
    }
}
