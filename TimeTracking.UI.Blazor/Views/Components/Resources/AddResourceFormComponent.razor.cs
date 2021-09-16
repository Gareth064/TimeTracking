using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Text.Json;
using TimeTracking.Core.Models;
using TimeTracking.UI.Blazor.Services.Resources;

namespace TimeTracking.UI.Blazor.Views.Components.Resources
{
    public partial class AddResourceFormComponent
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

        public void OnFinished(EditContext editContext)
        {
            _ = base.FeedbackRef.CloseAsync();
        }

        public void OnFinishedFailed(EditContext editContext)
        {
            Console.WriteLine($"Failed:{JsonSerializer.Serialize(resource)}");
        }





    }
}