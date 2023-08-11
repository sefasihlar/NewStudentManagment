using NLayer.Core.Concreate;

namespace NLayer.Core.Repositories
{
    public interface IProjectRepository : GenericRepository<Project>
    {
        Task<List<Project>> GetWithEmployeesList();

    }
}
