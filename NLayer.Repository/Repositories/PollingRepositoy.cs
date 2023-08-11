using Microsoft.EntityFrameworkCore;
using NLayer.Core.Concreate;
using NLayer.Core.Repositories;
using NLayer.Repository.Concreate;

namespace NLayer.Repository.Repositories
{
    public class PollingRepositoy : GenericRepositoy<Polling>, IPollingRepository
    {
        public PollingRepositoy(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Polling>> GetWithClassList()
        {
            return await _context.Pollings
                .Include(x => x.Class)
                .ToListAsync();
        }
    }
}
