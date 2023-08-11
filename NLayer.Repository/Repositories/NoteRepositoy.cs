using NLayer.Core.Concreate;
using NLayer.Core.Repositories;
using NLayer.Repository.Concreate;

namespace NLayer.Repository.Repositories
{
    public class NoteRepositoy : GenericRepositoy<Note>, INoteRepositoy
    {
        public NoteRepositoy(AppDbContext context) : base(context)
        {
        }
    }
}
