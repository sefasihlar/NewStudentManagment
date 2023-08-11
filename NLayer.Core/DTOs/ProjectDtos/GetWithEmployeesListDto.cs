using NLayer.Core.Concreate;

namespace NLayer.Core.DTOs.ProjectDtos
{
    public class GetWithEmployeesListDto : ProjectDto
    {
        public List<Project> Projects { get; set; }
    }
}
