using NLayer.Core.DTOs.EmployeesDtos;

namespace NLayer.Core.DTOs.DepartmentDtos
{
    public class GetWithEmployeesDto : DepartmentDto
    {
        public List<EmployeesDto> Employess { get; set; }
    }
}
