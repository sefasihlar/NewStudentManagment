using NLayer.Core.Concreate;

namespace NLayer.Core.Repositories
{
    public interface IPollingRepository : GenericRepository<Polling>
    {
        Task<List<Polling>> GetWithClassList();
    }
}
