using Microsoft.EntityFrameworkCore;
using NLayer.Core.Concreate;
using NLayer.Core.Repositories;
using NLayer.Repository.Concreate;

namespace NLayer.Repository.Repositories
{
    public class ProjectRepostory : GenericRepositoy<Project>, IProjectRepository
    {
        public ProjectRepostory(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Project>> GetWithEmployeesList()
        {
            return await _context.Projects
                .Include(x => x.ProjectEmployees)
                .ThenInclude(x => x.Employees)
                .ToListAsync();
        }
    }
}
