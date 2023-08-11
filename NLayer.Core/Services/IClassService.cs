using NLayer.Core.Concreate;
using NLayer.Core.DTOs;
using NLayer.Core.DTOs.ClassDtos;

namespace NLayer.Core.Services
{
    public interface IClassService : IService<Class>
    {
        public Task<CustomResponseDto<ClassWithStudentDto>> GetByClassIdWithStudentAsycn(int classId);
    }
}
