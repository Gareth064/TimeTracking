using TimeTracking.Core.Interfaces.Brokers;
using TimeTracking.Core.Models;

namespace TimeTracking.Core.Services.ActivityTypes
{
    public class ActivityTypeService : IActivityTypeService
    {
        private readonly IBroker broker;
        public ActivityTypeService(IBroker broker) => this.broker = broker;
        public async ValueTask<ActivityType> CreateActivityTypeAsync(ActivityType record)
        {
            return await this.broker.InsertActivityTypeAsync(record);
        }

        public async ValueTask<ActivityType> ModifyActivityTypeAsync(ActivityType record)
        {
            return await this.broker.UpdateActivityTypeAsync(record);
        }

        public async ValueTask<ActivityType> RemoveActivityTypeByIdAsync(Guid id)
        {
            ActivityType maybeActivityType = await broker.SelectActivityTypeByIdAsync(id);

            //TODO: do validation that the selected resource is the one to delete
            if (maybeActivityType is null)
                throw new Exception($"Unable to find Activity Type with Id '{id}' to remove.");
            if (maybeActivityType.Id != id)
                throw new Exception($"Returned ActivityType did not match '{id}'");

            return await this.broker.DeleteActivityTypeAsync(maybeActivityType);
        }

        public ValueTask<ActivityType> RetrieveActivityTypeByIdAsync(Guid id)
        {
            return this.broker.SelectActivityTypeByIdAsync(id);
        }

        public IQueryable<ActivityType> RetrieveAllActivityTypes()
        {
            IQueryable<ActivityType> activityTypes = this.broker.SelectAllActivityTypes();
            return activityTypes;
        }
    }
}
