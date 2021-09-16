using Microsoft.AspNetCore.Mvc;
using TimeTracking.Core.Models;
using TimeTracking.Core.Services.Resources;

namespace TimeTracking.UI.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ResourcesController : ControllerBase
{
    private readonly IResourceService resourceService;

    public ResourcesController(IResourceService resourceService) => this.resourceService = resourceService;

    [HttpGet]
    public ActionResult<IQueryable<Resource>> GetAllResources()
    {
        IQueryable resources = resourceService.RetrieveAllResources();
        return Ok(resources);
    }

    [HttpPost]
    public async ValueTask<ActionResult<Resource>> PostResourceAsync(Resource resource)
    {
        Resource persistedResource = await resourceService.CreateResourceAsync(resource);
        return Ok(persistedResource);
    }

    [HttpPut]
    public async ValueTask<ActionResult<Resource>> PutResourceAsync(Resource resource)
    {
        Resource updatedResource = await resourceService.ModifyResourceAsync(resource);
        return Ok(updatedResource);
    }

    [HttpDelete("{id}")]
    public async ValueTask<ActionResult<Resource>> DeleteResourceAsync(Guid id)
    {
        Resource deletedResource = await resourceService.RemoveResourceByIdAsync(id);
        return Ok(deletedResource);
    }
}
