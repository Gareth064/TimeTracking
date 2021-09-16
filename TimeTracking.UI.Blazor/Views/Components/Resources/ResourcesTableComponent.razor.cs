using Microsoft.AspNetCore.Components;
using TimeTracking.Core.Models;
using TimeTracking.UI.Blazor.Services.Resources;

namespace TimeTracking.UI.Blazor.Views.Components.Resources
{
    public partial class ResourcesTableComponent
    {
        [Inject]
        public IResourceService resourceService { get; set; }
        [Parameter]
        public bool loading { get; set; } = false;
        public List<Resource> ResourceRetrieved { get; set; } = new List<Resource>();
        [Parameter]
        public Resource ResourceToEdit { get; set; }

        protected override async Task OnInitializedAsync()
        {
            loading = true;
            await LoadResources();
            loading = false;
        }

        public async Task LoadResources()
        {
            ResourceRetrieved = await resourceService.RetrieveResourcesAsync();
            this.StateHasChanged();
        }

        public void EditClickedHandler(Resource resource)
        {
            ResourceToEdit = resource;
        }
    }
}