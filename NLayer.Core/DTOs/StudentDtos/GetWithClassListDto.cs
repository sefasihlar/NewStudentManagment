using NLayer.Core.DTOs.ClassDtos;
using NLayer.Core.DTOs.StudentDtod;

namespace NLayer.Core.DTOs.StudentDtos
{
    public class GetWithClassListDto : StudentDto
    {
        public ClassDto Class { get; set; }
    }
}
