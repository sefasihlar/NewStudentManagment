using NLayer.Core.Concreate;

namespace NLayer.Core.Repositories
{
    public interface IStudentRepository : GenericRepository<Student>
    {
        Task<List<Student>> GetWithClassList();
        Task<List<Student>> GetWithClassStudentList();
    }
}
