using NLayer.Core.Concreate;
using NLayer.Core.Repositories;
using NLayer.Repository.Concreate;

namespace NLayer.Repository.Repositories
{
    public class TodoListRepositoy : GenericRepositoy<TodoList>, ITodoListRepository
    {
        public TodoListRepositoy(AppDbContext context) : base(context)
        {
        }
    }
}
