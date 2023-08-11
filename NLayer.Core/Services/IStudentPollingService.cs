using NLayer.Core.Concreate;

namespace NLayer.Core.Services
{
    public interface IStudentPollingService : IService<StudentPolling>
    {
        Task RemoveStudentPollingAsync(int PollingId, int StudentId);
        Task<Polling> GetByPollingIdWithStudentList(int PollingId);
    }
}
