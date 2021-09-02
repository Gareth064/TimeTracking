using TimeTracking.Core.Models;

namespace TimeTracking.Core.Services.Resources
{
    public interface IResourceService
    {
        public ValueTask<Resource> RetrieveResourceByIdAsync(Guid id);
        public IQueryable<Resource> RetrieveAllResources();
        public ValueTask<Resource> ModifyResourceAsync(Resource record);
        public ValueTask<Resource> CreateResourceAsync(Resource record);
        public ValueTask<Resource> RemoveResourceByIdAsync(Guid id);
    }
}
