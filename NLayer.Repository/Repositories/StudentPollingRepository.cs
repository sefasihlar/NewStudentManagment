using Microsoft.EntityFrameworkCore;
using NLayer.Core.Concreate;
using NLayer.Core.Repositories;
using NLayer.Repository.Concreate;
using StudentPolling = NLayer.Core.Concreate.StudentPolling;

namespace NLayer.Repository.Repositories
{
    public class StudentPollingRepository : GenericRepositoy<StudentPolling>, IStudentPollingRepository
    {


        public StudentPollingRepository(AppDbContext context) : base(context)
        {
        }

        public async Task RemoveStudentPollingAsync(int PollingId, int StudentId)
        {
            var cmd = @"delete from StudentPollings where PollingId=@p0 And StudentId=@p1";
            _context.Database.ExecuteSqlRaw(cmd, PollingId, StudentId);
        }

        public async Task<Polling> GetByPollingIdWithStudentList(int PollingId)
        {
            return await _context.Pollings
                .Include(x => x.Class)
                .Where(x => x.Id == PollingId)
                .Include(x => x.StudentPollings)
                .ThenInclude(x => x.Student)
                .FirstOrDefaultAsync();

        }
    }
}
