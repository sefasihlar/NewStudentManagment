using NLayer.Core.DTOs.ClassDtos;
using NLayer.Core.DTOs.StudentDtod;

namespace NLayer.Core.DTOs.StudentDtos
{
    public class StudenWithClassDto : StudentDto
    {
        public ClassDto Class { get; set; }
    }
}
