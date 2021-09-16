using TimeTracking.Core.Models;

namespace TimeTracking.Core.Interfaces.Brokers
{
    public partial interface IBroker
    {
        public ValueTask<ActivityType> SelectActivityTypeByIdAsync(Guid id);
        public IQueryable<ActivityType> SelectAllActivityTypes();
        public ValueTask<ActivityType> UpdateActivityTypeAsync(ActivityType record);
        public ValueTask<ActivityType> InsertActivityTypeAsync(ActivityType record);
        public ValueTask<ActivityType> DeleteActivityTypeAsync(ActivityType record);
    }
}
