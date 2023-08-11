using NLayer.Core.Concreate;
using NLayer.Core.DTOs.PollingDtos;

namespace NLayer.Core.DTOs.StudentPollingDtos
{
    public class GetByPollingIdWithStudentDto : PollingDto
    {
        public List<Student> Students { get; set; }
    }
}
