using Microsoft.EntityFrameworkCore;
using ToDoList.Domain.Models.Common;
using ToDoList.Domain.Repositories;

namespace ToDoList.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseDomainEntity
    {
        private readonly ToDoListDBContext _dbContext;

        public GenericRepository(ToDoListDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> Create(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await _dbContext.Set<T>().FindAsync(id);
            if (entity == null)
                return false;
            _dbContext.Set<T>().Remove(entity);
            return true;
        }
    }
}