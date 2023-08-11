using NLayer.Core.Concreate;
using NLayer.Core.DTOs.DepartmentDtos;

namespace NLayer.Core.Services
{
    public interface IDepartmentService : IService<Department>
    {
        Task<List<GetWithEmployeesDto>> GetWithEmployeesList();
    }
}
