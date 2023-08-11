using NLayer.Core.Abstract;
using NLayer.Core.Concreate;

namespace NLayer.Core.DTOs.DepartmentDtos
{
    public class DepartmentDto : BaseDto
    {
        public string? Name { get; set; }
        public string? DepartmentManager { get; set; }
        public string? Description { get; set; }
        public bool Condition { get; set; }

        public List<Employees>? Employees { get; set; }
    }
}
