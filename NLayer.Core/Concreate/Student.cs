using NLayer.Core.Abstract;

namespace NLayer.Core.Concreate
{
    public class Student : BaseEntity
    {
        public string? StudentIdentity { get; set; }
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public int SchoolClass { get; set; }//Ogrencinin okuldaki sinifi
        public string? School { get; set; }
        public bool Gender { get; set; }

        public string? GuardianIdentity { get; set; }
        public string? GuardianName { get; set; }
        public string? GuardianSurName { get; set; }
        public string? GuardianJob { get; set; }
        public string? GuardianPhone { get; set; }
        public string? GuardianEmail { get; set; }
        public string? Adress { get; set; }

        public int Price { get; set; }


        public int ClassId { get; set; }
        public Class Class { get; set; }



        public List<StudentPolling> StudentPollings { get; set; }



    }
}
