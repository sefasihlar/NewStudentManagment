

using AutoMapper;
using NLayer.Core.Concreate;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Service.GenericManager;

namespace NLayer.Service.Services
{
    public class StudentPolllingService : Service<StudentPolling>, IStudentPollingService
    {
        private readonly IStudentPollingRepository _studentPollingRepository;
        private readonly IMapper _mapper;

        public StudentPolllingService(GenericRepository<StudentPolling> repository, IUnitOfWork unitOfWork, IStudentPollingRepository studentPollingRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _studentPollingRepository = studentPollingRepository;
            _mapper=mapper;
        }

        public async Task RemoveStudentPollingAsync(int PollingId, int StudentId)
        {
            await _studentPollingRepository.RemoveStudentPollingAsync(PollingId, StudentId);

        }

        public async Task<Polling> GetByPollingIdWithStudentList(int PollingId)
        {
            var student = await _studentPollingRepository.GetByPollingIdWithStudentList(PollingId);
            //var studentDto = student.StudentPollings.Select(x => x.Student).ToList();
            var studentDto = _mapper.Map<Polling>(student);
            return (studentDto);

        }
    }
}
