using NLayer.Core.Abstract;
using NLayer.Core.Concreate;

namespace NLayer.Core.DTOs.ProjectDtos
{
    public class ProjectDto : BaseDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ProjectManager { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal ComplationRate { get; set; }
        public bool Condition { get; set; }

        public int RemainingTime { get; set; }


        public List<ProjectEmployees> ProjectEmployees { get; set; }
    }
}
