using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TimeTracking.Core.Models;

namespace TimeTracking.Data.Brokers
{
    public partial class Broker
    {
        public DbSet<ActivityType> ActivityTypes { get; set; }

        public IQueryable<ActivityType> SelectAllActivityTypes() => this.ActivityTypes.AsQueryable();



        public async ValueTask<ActivityType> SelectActivityTypeByIdAsync(Guid id)
        {
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            return await ActivityTypes.FindAsync(id);
        }



        public async ValueTask<ActivityType> UpdateActivityTypeAsync(ActivityType activityType)
        {
            EntityEntry<ActivityType> auditEntityEntry = this.ActivityTypes.Update(activityType);
            await this.SaveChangesAsync();

            return auditEntityEntry.Entity;
        }



        public async ValueTask<ActivityType> InsertActivityTypeAsync(ActivityType activityType)
        {
            EntityEntry<ActivityType> auditEntityEntry = await this.ActivityTypes.AddAsync(activityType);
            await this.SaveChangesAsync();

            return auditEntityEntry.Entity;
        }



        public async ValueTask<ActivityType> DeleteActivityTypeAsync(ActivityType activityType)
        {
            EntityEntry<ActivityType> auditEntityEntry = this.ActivityTypes.Remove(activityType);
            await this.SaveChangesAsync();

            return auditEntityEntry.Entity;
        }
    }
}
