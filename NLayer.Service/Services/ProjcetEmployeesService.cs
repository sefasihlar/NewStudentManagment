﻿using NLayer.Core.Concreate;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Service.GenericManager;

namespace NLayer.Service.Services
{
    public class ProjcetEmployeesService : Service<ProjectEmployees>, IProjectEmployeesService
    {
        public ProjcetEmployeesService(GenericRepository<ProjectEmployees> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
