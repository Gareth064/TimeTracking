using TimeTracking.Core.Interfaces.Brokers;
using TimeTracking.Core.Models;

namespace TimeTracking.Core.Services.TimeSheetHeaders
{
    public class TimeSheetHeaderService
    {
        private readonly IBroker broker;
        public TimeSheetHeaderService(IBroker broker) => this.broker = broker;
        public async ValueTask<TimeSheetHeader> CreateTimeSheetHeaderAsync(TimeSheetHeader record)
        {
            return await this.broker.InsertTimeSheetHeaderAsync(record);
        }

        public async ValueTask<TimeSheetHeader> ModifyTimeSheetHeaderAsync(TimeSheetHeader record)
        {
            return await this.broker.UpdateTimeSheetHeaderAsync(record);
        }

        public async ValueTask<TimeSheetHeader> RemoveTimeSheetHeaderByIdAsync(Guid id)
        {
            TimeSheetHeader maybeTimeSheetHeader = await broker.SelectTimeSheetHeaderByIdAsync(id);

            //TODO: do validation that the selected resource is the one to delete
            if (maybeTimeSheetHeader is null)
                throw new Exception($"Unable to find TimeSheet Header with Id '{id}' to remove.");
            if (maybeTimeSheetHeader.Id != id)
                throw new Exception($"Returned TimeSheetHeader did not match '{id}'");

            return await this.broker.DeleteTimeSheetHeaderAsync(maybeTimeSheetHeader);
        }

        public ValueTask<TimeSheetHeader> RetrieveTimeSheetHeaderByIdAsync(Guid id)
        {
            return this.broker.SelectTimeSheetHeaderByIdAsync(id);
        }

        public IQueryable<TimeSheetHeader> RetrieveAllTimeSheetHeaders()
        {
            IQueryable<TimeSheetHeader> TimeSheetHeaders = this.broker.SelectAllTimeSheetHeaders();
            return TimeSheetHeaders;
        }
    }
}
