using ToDoList.Domain.Models;

namespace ToDoList.Domain.Repositories
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        Task<IEnumerable<Comment>> GetCommentsByWorkItemId(int id);
    }
}