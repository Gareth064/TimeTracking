
using TimeTracking.Core.Models;
using TimeTracking.UI.Blazor.Brokers.Api;

namespace TimeTracking.UI.Blazor.Services.Resources;
public class ResourceService : IResourceService
{
    private readonly IApiBroker apiBroker;

    public ResourceService(IApiBroker apiBroker)
    {
        this.apiBroker = apiBroker;
    }

    public async ValueTask<Resource> AddResourceAsync(Resource record)
    {
        return await this.apiBroker.PostResourceAsync(record);
    }

    public async ValueTask<List<Resource>> RetrieveResourcesAsync()
    {
        return await this.apiBroker.GetResourcesAsync();
    }
}
