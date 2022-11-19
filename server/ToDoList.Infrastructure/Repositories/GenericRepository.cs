using ToDoList.Domain.Models;
using ToDoList.Domain.Repositories;

namespace ToDoList.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T: BaseDomainEntity
    {
        private readonly ToDoListDBContext _dbContext;

        public GenericRepository(ToDoListDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Create(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}