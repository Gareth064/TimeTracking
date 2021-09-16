namespace TimeTracking.Core.Models
{
    public class ActivityType
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name {  get; set; } 
        public string Description {  get; set; }
        public bool BillableActivity { get; set; }
        public bool Enabled { get; set; }

    }
}
