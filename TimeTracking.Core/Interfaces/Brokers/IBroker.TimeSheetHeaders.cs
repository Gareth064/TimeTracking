using TimeTracking.Core.Models;

namespace TimeTracking.Core.Interfaces.Brokers
{
    public partial interface IBroker
    {
        public ValueTask<TimeSheetHeader> SelectTimeSheetHeaderByIdAsync(Guid id);
        public IQueryable<TimeSheetHeader> SelectAllTimeSheetHeaders();
        public ValueTask<TimeSheetHeader> UpdateTimeSheetHeaderAsync(TimeSheetHeader record);
        public ValueTask<TimeSheetHeader> InsertTimeSheetHeaderAsync(TimeSheetHeader record);
        public ValueTask<TimeSheetHeader> DeleteTimeSheetHeaderAsync(TimeSheetHeader record);
    }
}
