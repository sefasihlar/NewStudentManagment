using AutoMapper;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs.ProjectDtos;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Service.GenericManager;

namespace NLayer.Service.Services
{
    public class ProjectService : Service<Project>, IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;

        public ProjectService(GenericRepository<Project> repository, IUnitOfWork unitOfWork, IProjectRepository projectRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _projectRepository=projectRepository;
            _mapper=mapper;
        }

        public async Task<List<GetWithEmployeesListDto>> GetWithEmployeesList()
        {
            var values = await _projectRepository.GetWithEmployeesList();
            var valuesDto = _mapper.Map<List<GetWithEmployeesListDto>>(values);
            return valuesDto.ToList();
        }
    }
}
