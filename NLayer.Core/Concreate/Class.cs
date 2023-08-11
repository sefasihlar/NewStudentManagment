
using NLayer.Core.Abstract;

namespace NLayer.Core.Concreate
{
    public class Class : BaseEntity
    {
        public string? Name { get; set; }
        public int WeekCount { get; set; }
        public string? ImageUrl { get; set; }


        public List<ClassDay> ClassDays { get; set; }
        public List<Student> Students { get; set; }
    }
}
