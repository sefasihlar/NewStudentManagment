using NLayer.Core.Concreate;

namespace NLayer.Core.Repositories
{
    public interface IStudentPollingRepository : GenericRepository<StudentPolling>
    {
        Task RemoveStudentPollingAsync(int PollingId, int StudentId);

        Task<Polling> GetByPollingIdWithStudentList(int PollingId);
    }
}