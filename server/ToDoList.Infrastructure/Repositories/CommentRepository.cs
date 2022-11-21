using ToDoList.Domain.Models;
using ToDoList.Domain.Repositories;

namespace ToDoList.Infrastructure.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        private readonly ToDoListDBContext _dbContext;

        public CommentRepository(ToDoListDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Comment>> GetCommentsByWorkItemId(int id)
        {
            return _dbContext.Comments.Where(x => x.Id.Equals(id)); //TODO association with workitem!
        }
    }
}