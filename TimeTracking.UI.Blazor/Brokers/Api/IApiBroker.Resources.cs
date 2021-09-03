using TimeTracking.Core.Models;

namespace TimeTracking.UI.Blazor.Brokers.Api;
public partial interface IApiBroker
{
    ValueTask<List<Resource>> GetResourcesAsync();
    ValueTask<Resource> PostResourceAsync(Resource record);
}
