namespace TimeTracking.Core.Models
{
    public class Resource
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name {  get; set; }
        public string EmailAddress { get; set; }
        public bool Enabled { get; set; }
    }
}
