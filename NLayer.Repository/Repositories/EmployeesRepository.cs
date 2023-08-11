using NLayer.Core.Concreate;
using NLayer.Core.Repositories;
using NLayer.Repository.Concreate;

namespace NLayer.Repository.Repositories
{
    public class EmployeesRepository : GenericRepositoy<Employees>, IEmployeesRepository
    {
        public EmployeesRepository(AppDbContext context) : base(context)
        {
        }
    }
}
