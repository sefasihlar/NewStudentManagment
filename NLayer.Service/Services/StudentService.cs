using AutoMapper;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs;
using NLayer.Core.DTOs.StudentDtos;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Service.GenericManager;

namespace NLayer.Service.Services
{
    public class StudentService : Service<Student>, IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentService(GenericRepository<Student> repository, IUnitOfWork unitOfWork, IMapper mapper, IStudentRepository studentRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _studentRepository = studentRepository;
        }

        public async Task<CustomResponseDto<List<StudenWithClassDto>>> GetWithClassList()
        {
            var student = await _studentRepository.GetWithClassList();

            var studentDto = _mapper.Map<List<StudenWithClassDto>>(student);

            return CustomResponseDto<List<StudenWithClassDto>>.Success(200, studentDto);
        }

        public async Task<List<GetWithClassListDto>> GetWithClassStudentList()
        {
            var student = await _studentRepository.GetWithClassStudentList();
            var studentDto = _mapper.Map<List<GetWithClassListDto>>(student);
            return studentDto.ToList();
        }
    }
}
