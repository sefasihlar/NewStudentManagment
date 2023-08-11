using Microsoft.EntityFrameworkCore;
using NLayer.Core.Concreate;
using NLayer.Core.Repositories;
using NLayer.Repository.Concreate;

namespace NLayer.Repository.Repositories
{
    public class PaymenetRepository : GenericRepositoy<Payment>, IPaymentRepository
    {
        public PaymenetRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<Payment> GetByIdWithStudent(int id)
        {
            return await _context.Payments
                .Include(x => x.Student)
                .FirstOrDefaultAsync(a => a.Id == id);
        }


        public async Task<List<Payment>> GetWithStudentList()
        {
            return await _context.Payments
                .Include(x => x.Student)
                .ToListAsync();
        }
    }
}
