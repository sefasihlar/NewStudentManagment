using NLayer.Core.Abstract;

namespace NLayer.Core.DTOs.ClassDtos
{
    public class ClassDto : BaseDto
    {
        public string? Name { get; set; }
        public int WeekCount { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Condition { get; set; }
    }
}
