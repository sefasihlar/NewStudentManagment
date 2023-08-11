using NLayer.Core.DTOs.StudentDtod;

namespace NLayer.Core.DTOs.PaymentDtos
{
    public class GetWithStudentListDto : PaymentDto
    {
        public StudentDto Student { get; set; }
    }
}
