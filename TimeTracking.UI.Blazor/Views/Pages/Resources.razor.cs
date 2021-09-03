using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.JSInterop;
using TimeTracking.UI.Blazor;
using TimeTracking.UI.Blazor.Shared;
using TimeTracking.Core.Models;
using TimeTracking.UI.Blazor.Services.Resources;

namespace TimeTracking.UI.Blazor.Views.Pages
{
    public partial class Resources
    {
        [Inject]
        public IResourceService resourceService { get; set;  }
        public bool loading { get; set; } = false;
        public List<Resource> ResourceRetrieved { get; set; } = new List<Resource>();

        protected override async Task OnInitializedAsync()
        {
            loading = true;
            ResourceRetrieved = await resourceService.RetrieveResourcesAsync();
            loading = false;
        }
        public void Edit()
        {

        }


    }
}