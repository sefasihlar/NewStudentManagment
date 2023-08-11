using NLayer.Core.Abstract;

namespace NLayer.Core.Concreate
{
    public class Project : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ProjectManager { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal ComplationRate { get; set; }


        public List<ProjectEmployees> ProjectEmployees { get; set; }

    }
}
