using NLayer.Core.Concreate;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Service.GenericManager;

namespace NLayer.Service.Services
{
    public class ClassDayService : Service<ClassDay>, IClassDayService
    {
        private readonly IClassDayRepository _classDayRepository;
        public ClassDayService(GenericRepository<ClassDay> repository, IUnitOfWork unitOfWork, IClassDayRepository classDayRepository) : base(repository, unitOfWork)
        {
            _classDayRepository = classDayRepository;
        }

        public async Task RemoveClassDaysAsync(int ClassId, int DayId)
        {
            await _classDayRepository.RemoveClassDaysAsync(ClassId, DayId);
        }
    }
}
