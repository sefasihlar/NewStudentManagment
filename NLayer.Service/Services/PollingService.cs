using AutoMapper;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs.PollingDtos;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Service.GenericManager;

namespace NLayer.Service.Services
{
    public class PollingService : Service<Polling>, IPollingService
    {
        private readonly IPollingRepository _pollingRepository;
        private readonly IMapper _mapper;

        public PollingService(GenericRepository<Polling> repository, IUnitOfWork unitOfWork, IPollingRepository pollingRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _pollingRepository = pollingRepository;
            _mapper = mapper;
        }

        public async Task<List<GetWithClassPollingListDto>> GetWithClassList()
        {
            var polling = await _pollingRepository.GetWithClassList();
            var pollingDto = _mapper.Map<List<GetWithClassPollingListDto>>(polling);
            return pollingDto.ToList();
        }
    }
}
