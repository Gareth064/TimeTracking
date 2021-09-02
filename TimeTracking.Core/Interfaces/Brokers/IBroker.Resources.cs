using TimeTracking.Core.Models;

namespace TimeTracking.Core.Interfaces.Brokers
{
    public partial interface IBroker
    {
        public ValueTask<Resource> SelectResourceByIdAsync(Guid id);
        public IQueryable<Resource> SelectAllResources();
        public ValueTask<Resource> UpdateResourceAsync(Resource record);
        public ValueTask<Resource> InsertResourceAsync(Resource record);
        public ValueTask<Resource> DeleteResourceAsync(Resource record);
    }
}
