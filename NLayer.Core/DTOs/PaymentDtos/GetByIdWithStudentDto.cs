using NLayer.Core.DTOs.StudentDtod;

namespace NLayer.Core.DTOs.PaymentDtos
{
    public class GetByIdWithStudentDto : PaymentDto
    {
        public StudentDto Student { get; set; }
    }
}
