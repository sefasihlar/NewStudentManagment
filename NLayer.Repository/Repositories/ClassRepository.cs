using Microsoft.EntityFrameworkCore;
using NLayer.Core.Concreate;
using NLayer.Core.Repositories;
using NLayer.Repository.Concreate;

namespace NLayer.Repository.Repositories
{
    public class ClassRepository : GenericRepositoy<Class>, IClassRepository
    {
        public ClassRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Class> GetByClassIdWithStudentAsycn(int classId)
        {
            return await _context.Classes
                .Include(a => a.Students).Where(a => a.Id == classId).SingleOrDefaultAsync();
        }
    }
}
