
using TimeTracking.Core.Models;

namespace TimeTracking.UI.Blazor.Brokers.Api;
public partial class ApiBroker
{
    private const string RelativeUrl = "api/resources";
    public async ValueTask<List<Resource>> GetResourcesAsync()
    {
        var result = await this.GetAsync<List<Resource>>(RelativeUrl);
        return result;
    }

    public async ValueTask<Resource> PostResourceAsync(Resource record)
    {
        var result = await this.PostAsync<Resource>(RelativeUrl, record);
        return result; 
    }
}
