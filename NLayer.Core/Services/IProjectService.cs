using NLayer.Core.Concreate;
using NLayer.Core.DTOs.ProjectDtos;

namespace NLayer.Core.Services
{
    public interface IProjectService : IService<Project>
    {
        Task<List<GetWithEmployeesListDto>> GetWithEmployeesList();
    }
}
