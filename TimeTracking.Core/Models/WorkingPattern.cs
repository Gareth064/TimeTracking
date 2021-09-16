namespace TimeTracking.Core.Models
{
public class WorkingPattern
    {
        public Guid Id { get; set; } = new Guid();
        public Resource Resource { get; set; }
        public decimal DaysPerWeek { get; set; }
        public decimal HoursPerDay { get; set; }
        public DateTimeOffset StartedOn { get; set; }
        public DateTimeOffset EndedOn { get; set; }
    }
}
