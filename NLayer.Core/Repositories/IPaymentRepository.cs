using NLayer.Core.Concreate;

namespace NLayer.Core.Repositories
{
    public interface IPaymentRepository : GenericRepository<Payment>
    {
        Task<List<Payment>> GetWithStudentList();
        Task<Payment> GetByIdWithStudent(int id);
    }
}
