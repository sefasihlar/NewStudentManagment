using Microsoft.EntityFrameworkCore;
using NLayer.Core.Concreate;
using NLayer.Core.Repositories;
using NLayer.Repository.Concreate;

namespace NLayer.Repository.Repositories
{
    public class DepartmentRepositoy : GenericRepositoy<Department>, IDepartmentRepository
    {
        public DepartmentRepositoy(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Department>> GetWithEmployeesList()
        {
            return await _context.Departments
                .Include(x => x.Employees)
                .ToListAsync();
        }
    }
}
