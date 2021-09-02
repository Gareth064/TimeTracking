using TimeTracking.Core.Models;

namespace TimeTracking.Core.Services.ActivityTypes
{
    public interface IActivityTypeService
    {
        public ValueTask<ActivityType> RetrieveActivityTypeByIdAsync(Guid id);
        public IQueryable<ActivityType> RetrieveAllActivityTypes();
        public ValueTask<ActivityType> ModifyActivityTypeAsync(ActivityType record);
        public ValueTask<ActivityType> CreateActivityTypeAsync(ActivityType record);
        public ValueTask<ActivityType> RemoveActivityTypeByIdAsync(Guid id);
    }
}
