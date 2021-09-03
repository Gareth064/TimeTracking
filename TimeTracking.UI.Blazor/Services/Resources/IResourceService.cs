using TimeTracking.Core.Models;

namespace TimeTracking.UI.Blazor.Services.Resources;
public interface IResourceService
{
    ValueTask<List<Resource>> RetrieveResourcesAsync();
    ValueTask<Resource> AddResourceAsync(Resource record);
}
