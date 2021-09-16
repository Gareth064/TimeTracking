using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TimeTracking.Core.Interfaces.Brokers;

namespace TimeTracking.Data.Brokers
{
    public partial class Broker : DbContext, IBroker
    {
        private readonly IConfiguration configuration;
        public Broker(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.Database.Migrate();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            AddActivityTypeConfiguration(modelBuilder);
            AddResourceConfiguration(modelBuilder);
            AddTimeSheetHeaderConfiguration(modelBuilder);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = this.configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
