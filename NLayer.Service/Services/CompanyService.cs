using NLayer.Core.Concreate;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Service.GenericManager;

namespace NLayer.Service.Services
{
    public class CompanyService : Service<Company>, ICompanyService
    {
        public CompanyService(GenericRepository<Company> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

    }
}
