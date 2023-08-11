namespace NLayer.Core.Concreate
{
    public class ProjectEmployees
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }


        public int EmployeesId { get; set; }
        public Employees Employees { get; set; }
    }
}
