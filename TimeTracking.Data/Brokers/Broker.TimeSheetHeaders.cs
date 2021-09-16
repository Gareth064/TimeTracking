using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TimeTracking.Core.Models;

namespace TimeTracking.Data.Brokers
{
    public partial class Broker
    {
        public DbSet<TimeSheetHeader> TimeSheetHeaders { get; set; }

        public IQueryable<TimeSheetHeader> SelectAllTimeSheetHeaders() => this.TimeSheetHeaders.AsQueryable();



        public async ValueTask<TimeSheetHeader> SelectTimeSheetHeaderByIdAsync(Guid id)
        {
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            return await TimeSheetHeaders.FindAsync(id);
        }



        public async ValueTask<TimeSheetHeader> UpdateTimeSheetHeaderAsync(TimeSheetHeader record)
        {
            EntityEntry<TimeSheetHeader> auditEntityEntry = this.TimeSheetHeaders.Update(record);
            await this.SaveChangesAsync();

            return auditEntityEntry.Entity;
        }



        public async ValueTask<TimeSheetHeader> InsertTimeSheetHeaderAsync(TimeSheetHeader record)
        {
            EntityEntry<TimeSheetHeader> auditEntityEntry = await this.TimeSheetHeaders.AddAsync(record);
            await this.SaveChangesAsync();

            return auditEntityEntry.Entity;
        }



        public async ValueTask<TimeSheetHeader> DeleteTimeSheetHeaderAsync(TimeSheetHeader record)
        {
            EntityEntry<TimeSheetHeader> auditEntityEntry = this.TimeSheetHeaders.Remove(record);
            await this.SaveChangesAsync();

            return auditEntityEntry.Entity;
        }
    }
}
