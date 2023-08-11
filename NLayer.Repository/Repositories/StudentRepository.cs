using Microsoft.EntityFrameworkCore;
using NLayer.Core.Concreate;
using NLayer.Core.Repositories;
using NLayer.Repository.Concreate;

namespace NLayer.Repository.Repositories
{
    public class StudentRepository : GenericRepositoy<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Student>> GetWithClassList()
        {

            return await _context.Students
                .Include(a => a.Class)
                .ToListAsync();
        }

        public async Task<List<Student>> GetWithClassStudentList()
        {
            return await _context.Students
               .Include(a => a.Class)
               .ToListAsync();
        }
    }
}
