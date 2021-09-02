using TimeTracking.Core.Interfaces.Brokers;
using TimeTracking.Core.Models;

namespace TimeTracking.Core.Services.Resources
{
    public partial class ResourceService : IResourceService
    {
        private readonly IBroker broker;
        public ResourceService(IBroker broker) => this.broker = broker;
        public async ValueTask<Resource> CreateResourceAsync(Resource record)
        {
            return await this.broker.InsertResourceAsync(record);
        }

        public async ValueTask<Resource> ModifyResourceAsync(Resource record)
        {
            return await this.broker.UpdateResourceAsync(record);
        }

        public async ValueTask<Resource> RemoveResourceByIdAsync(Guid id)
        {
            Resource maybeResource = await broker.SelectResourceByIdAsync(id);
            
            //TODO: do validation that the selected resource is the one to delete
            if (maybeResource is null)
                throw new Exception($"Unable to find Resource with Id '{id}' to remove.");
            if (maybeResource.Id != id)
                throw new Exception($"Returned Resource did not match '{id}'");

            return await this.broker.DeleteResourceAsync(maybeResource);
        }

        public IQueryable<Resource> RetrieveAllResources()
        {
            IQueryable<Resource> resources = this.broker.SelectAllResources();
            return resources;
        }

        public ValueTask<Resource> RetrieveResourceByIdAsync(Guid id)
        {
            return this.broker.SelectResourceByIdAsync(id);
        }
    }
}
