

using NLayer.Core.Concreate;

namespace NLayer.Core.Repositories
{
    public interface IClassDayRepository : GenericRepository<ClassDay>
    {
        Task RemoveClassDaysAsync(int ClassId, int DayId);
    }
}
