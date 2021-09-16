namespace TimeTracking.Core.Models
{
    public class Team
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public Team ParentTeam { get; set; }
        public Department Department { get; set; }
    }
}
