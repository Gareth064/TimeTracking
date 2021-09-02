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

namespace TimeTracking.UI.Blazor.Views.Pages
{
    public partial class Resources
    {
        public List<Resource> ResourceRetrieved { get; set; } = new List<Resource>();

        protected override Task OnInitializedAsync()
        {
            ResourceRetrieved.Add(new Resource { Id = Guid.NewGuid(), Name = "Gareth Doherty", EmailAddress = "gd@gd.com", Enabled = true });
            ResourceRetrieved.Add(new Resource { Id = Guid.NewGuid(), Name = "George Patton", EmailAddress = "gp@gp.com", Enabled = true });
            ResourceRetrieved.Add(new Resource { Id = Guid.NewGuid(), Name = "John Doe", EmailAddress = "jd@jd.com", Enabled = true });
            ResourceRetrieved.Add(new Resource { Id = Guid.NewGuid(), Name = "Sherley Donahugh", EmailAddress = "sd@sd.com", Enabled = true });
            return base.OnInitializedAsync();  
        }
        public void Edit()
        {

        }


    }
}