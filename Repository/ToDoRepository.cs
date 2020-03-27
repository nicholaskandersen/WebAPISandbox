using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class ToDoRepository : RepositoryBase<ToDo>, IToDoRepository
    {
        public ToDoRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
