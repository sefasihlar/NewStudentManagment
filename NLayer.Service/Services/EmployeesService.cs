﻿using NLayer.Core.Concreate;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Service.GenericManager;

namespace NLayer.Service.Services
{
    public class EmployeesService : Service<Employees>, IEmployeesService
    {
        public EmployeesService(GenericRepository<Employees> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
