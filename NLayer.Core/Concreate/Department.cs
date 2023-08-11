using NLayer.Core.Abstract;

namespace NLayer.Core.Concreate
{
    public class Department : BaseEntity
    {
        public string? Name { get; set; }
        public string? DepartmentManager { get; set; }
        public string? Description { get; set; }

        public List<Employees>? Employees { get; set; }

    }
}
