using TimeTracking.Core.Models;

namespace TimeTracking.Core.Services.TimeSheetHeaders
{
    public interface ITimeSheetHeaderService
    {
        public ValueTask<TimeSheetHeader> RetrieveTimeSheetHeaderByIdAsync(Guid id);
        public IQueryable<TimeSheetHeader> RetrieveAllTimeSheetHeaders();
        public ValueTask<TimeSheetHeader> ModifyTimeSheetHeaderAsync(TimeSheetHeader record);
        public ValueTask<TimeSheetHeader> CreateTimeSheetHeaderAsync(TimeSheetHeader record);
        public ValueTask<TimeSheetHeader> RemoveTimeSheetHeaderByIdAsync(Guid id);
    }
}
