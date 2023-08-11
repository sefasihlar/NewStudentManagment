using NLayer.Core.Abstract;

namespace NLayer.Core.Concreate
{
    public class DepartmentEmployees : BaseEntity
    {
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public int EmployeesId { get; set; }
        public Employees Employees { get; set; }
    }
}
