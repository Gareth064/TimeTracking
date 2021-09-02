using Microsoft.AspNetCore.Mvc;
using TimeTracking.Core.Models;
using TimeTracking.Core.Services.ActivityTypes;

namespace TimeTracking.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ActivityTypesController : ControllerBase
{
    private readonly IActivityTypeService activityTypeService;

    public ActivityTypesController(IActivityTypeService activityTypeService)
    {
        this.activityTypeService = activityTypeService;
    }

    [HttpGet]
    public ActionResult<IQueryable<ActivityType>> GetAllActivityTypes()
    {
        IQueryable activityTypes = activityTypeService.RetrieveAllActivityTypes();
        return Ok(activityTypes);
    }

    [HttpPost]
    public async ValueTask<ActionResult<ActivityType>> PostActivityTypeAsync(ActivityType activityType)
    {
        ActivityType persistedActivityType = await activityTypeService.CreateActivityTypeAsync(activityType);
        return Ok(persistedActivityType);
    }

    [HttpPut]
    public async ValueTask<ActionResult<ActivityType>> PutActivityTypeAsync(ActivityType activityType)
    {
        ActivityType updatedActivityType = await activityTypeService.ModifyActivityTypeAsync(activityType);
        return Ok(updatedActivityType);
    }

    [HttpDelete("{id}")]
    public async ValueTask<ActionResult<ActivityType>> DeleteActivityTypeAsync(Guid id)
    {
        ActivityType deletedActivityType = await activityTypeService.RemoveActivityTypeByIdAsync(id);
        return Ok(deletedActivityType);
    }
}
