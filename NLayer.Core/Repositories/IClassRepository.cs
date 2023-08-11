using NLayer.Core.Concreate;

namespace NLayer.Core.Repositories
{
    public interface IClassRepository : GenericRepository<Class>
    {
        Task<Class> GetByClassIdWithStudentAsycn(int classId);
    }
}
