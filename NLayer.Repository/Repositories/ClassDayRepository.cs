using Microsoft.EntityFrameworkCore;
using NLayer.Core.Concreate;
using NLayer.Core.Repositories;
using NLayer.Repository.Concreate;

namespace NLayer.Repository.Repositories
{
    public class ClassDayRepository : GenericRepositoy<ClassDay>, IClassDayRepository
    {
        public ClassDayRepository(AppDbContext context) : base(context)
        {
        }


        public async Task RemoveClassDaysAsync(int ClassId, int DayId)
        {
            var cmd = @"delete from ClassDays where ClassId=@p0 And DayId=@p1";
            _context.Database.ExecuteSqlRaw(cmd, ClassId, DayId);
        }
    }
}
