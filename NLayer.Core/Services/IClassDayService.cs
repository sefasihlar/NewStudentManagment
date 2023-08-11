
using NLayer.Core.Concreate;

namespace NLayer.Core.Services
{
    public interface IClassDayService : IService<ClassDay>
    {
        Task RemoveClassDaysAsync(int ClassId, int DayId);
    }
}
