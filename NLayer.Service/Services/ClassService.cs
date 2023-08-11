using AutoMapper;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs;
using NLayer.Core.DTOs.ClassDtos;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Service.GenericManager;

namespace NLayer.Service.Services
{
    public class ClassService : Service<Class>, IClassService
    {
        private readonly IClassRepository _classRepository;
        private readonly IMapper _mapper;


        public ClassService(GenericRepository<Class> repository, IUnitOfWork unitOfWork, IClassRepository classRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _classRepository = classRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<ClassWithStudentDto>> GetByClassIdWithStudentAsycn(int classId)
        {
            var _class = await _classRepository.GetByClassIdWithStudentAsycn(classId);
            var classDto = _mapper.Map<ClassWithStudentDto>(_class);
            return CustomResponseDto<ClassWithStudentDto>.Success(200, classDto);
        }
    }
}
