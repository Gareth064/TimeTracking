using Microsoft.AspNetCore.Components;
using TimeTracking.Core.Models;
using TimeTracking.UI.Blazor.Services.Resources;

namespace TimeTracking.UI.Blazor.Views.Components.Resources
{
    public partial class AddResourceComponent
    {
        [Inject]
        public IResourceService resourceService { get; set; }

        public Resource resource = new Resource();
        public bool submitting { get; set; } = false;

        private async Task SubmitAddResourceForm()
        {
            submitting = true;
            await resourceService.AddResourceAsync(resource);
            submitting = false;
        }





    }
}