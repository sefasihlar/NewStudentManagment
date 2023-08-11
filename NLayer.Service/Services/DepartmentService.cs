using AutoMapper;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs.DepartmentDtos;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Service.GenericManager;

namespace NLayer.Service.Services
{
    public class DepartmentService : Service<Department>, IDepartmentService
    {

        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public DepartmentService(GenericRepository<Department> repository, IUnitOfWork unitOfWork, IDepartmentRepository departmentRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }


        public async Task<List<GetWithEmployeesDto>> GetWithEmployeesList()
        {
            var values = await _departmentRepository.GetWithEmployeesList();
            var valuesDto = _mapper.Map<List<GetWithEmployeesDto>>(values);
            return valuesDto.ToList();
        }


    }
}
