using NLayer.Core.Concreate;
using NLayer.Core.DTOs;
using NLayer.Core.DTOs.StudentDtos;

namespace NLayer.Core.Services
{
    public interface IStudentService : IService<Student>
    {
        Task<CustomResponseDto<List<StudenWithClassDto>>> GetWithClassList();
        Task<List<GetWithClassListDto>> GetWithClassStudentList();

    }
}
