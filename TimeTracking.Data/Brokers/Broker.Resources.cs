using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TimeTracking.Core.Models;

namespace TimeTracking.Data.Brokers
{
    public partial class Broker
    {
        public DbSet<Resource> Resources { get; set; }

        public IQueryable<Resource> SelectAllResources() => this.Resources.AsQueryable();



        public async ValueTask<Resource> SelectResourceByIdAsync(Guid id)
        {
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            return await Resources.FindAsync(id);
        }



        public async ValueTask<Resource> UpdateResourceAsync(Resource resource)
        {
            EntityEntry<Resource> auditEntityEntry = this.Resources.Update(resource);
            await this.SaveChangesAsync();

            return auditEntityEntry.Entity;
        }



        public async ValueTask<Resource> InsertResourceAsync(Resource resource)
        {
            EntityEntry<Resource> auditEntityEntry = await this.Resources.AddAsync(resource);
            await this.SaveChangesAsync();

            return auditEntityEntry.Entity;
        }



        public async ValueTask<Resource> DeleteResourceAsync(Resource resource)
        {
            EntityEntry<Resource> auditEntityEntry = this.Resources.Remove(resource);
            await this.SaveChangesAsync();

            return auditEntityEntry.Entity;
        }
    }
}
