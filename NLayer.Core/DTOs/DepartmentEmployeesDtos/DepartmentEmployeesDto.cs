using NLayer.Core.Abstract;
using NLayer.Core.Concreate;

namespace NLayer.Core.DTOs.DepartmentEmployeesDtos
{
    public class DepartmentEmployeesDto : BaseDto
    {
        public int DepartmentId { get; set; }
        public Department Department { get; set; }


        public int EmployeesId { get; set; }
        public Employees Employees { get; set; }
    }
}
