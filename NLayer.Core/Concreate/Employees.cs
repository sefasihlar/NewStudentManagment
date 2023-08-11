using NLayer.Core.Abstract;

namespace NLayer.Core.Concreate
{
    public class Employees : BaseEntity
    {
        public string? TCKN { get; set; }
        public string? Title { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public int Salary { get; set; }
        public string? Iban { get; set; }
        public string? Location { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime FinishDate { get; set; }

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public string? Mother { get; set; }
        public string? Father { get; set; }
        public string? UrgentPerson { get; set; }
        public string? UrgentPhone { get; set; }
        public string? Address { get; set; }

        public string? ImageUrl { get; set; }


        public List<ProjectEmployees> ProjectEmployees { get; set; }



    }
}
