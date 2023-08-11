using NLayer.Core.Concreate;
using NLayer.Core.DTOs.PollingDtos;

namespace NLayer.Core.Services
{
    public interface IPollingService : IService<Polling>
    {
        Task<List<GetWithClassPollingListDto>> GetWithClassList();
    }
}
