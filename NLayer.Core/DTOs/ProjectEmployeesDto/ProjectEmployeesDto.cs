using NLayer.Core.Abstract;

namespace NLayer.Core.DTOs.ProjectEmployeesDto
{
    public class ProjectEmployeesDto : BaseEntity
    {
        public int ProjectId { get; set; }
        public int EmployeesId { get; set; }
    }
}
