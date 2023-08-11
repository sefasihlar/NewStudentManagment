using NLayer.Core.Concreate;
using NLayer.Core.Repositories;
using NLayer.Repository.Concreate;

namespace NLayer.Repository.Repositories
{
    public class ProjcetEmployeesRepository : GenericRepositoy<ProjectEmployees>, IProjectEmployeesRepository
    {
        public ProjcetEmployeesRepository(AppDbContext context) : base(context)
        {
        }
    }
}
