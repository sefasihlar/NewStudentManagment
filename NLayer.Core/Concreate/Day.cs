using NLayer.Core.Abstract;

namespace NLayer.Core.Concreate
{
    public class Day : BaseEntity
    {
        public string Name { get; set; }
        public List<ClassDay> ClassDays { get; set; }
    }
}
