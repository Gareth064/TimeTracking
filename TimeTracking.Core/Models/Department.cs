namespace TimeTracking.Core.Models
{
    public class Department
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
    }
}