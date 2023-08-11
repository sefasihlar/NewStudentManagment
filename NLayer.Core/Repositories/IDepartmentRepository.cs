using NLayer.Core.Concreate;

namespace NLayer.Core.Repositories
{
    public interface IDepartmentRepository : GenericRepository<Department>
    {
        Task<List<Department>> GetWithEmployeesList();
    }
}
