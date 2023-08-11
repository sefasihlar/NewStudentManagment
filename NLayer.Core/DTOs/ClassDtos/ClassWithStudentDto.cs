using NLayer.Core.DTOs.StudentDtod;

namespace NLayer.Core.DTOs.ClassDtos
{
    public class ClassWithStudentDto : ClassDto
    {
        public List<StudentDto> Students { get; set; }
    }
}
