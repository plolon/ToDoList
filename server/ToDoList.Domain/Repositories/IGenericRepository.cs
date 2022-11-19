using ToDoList.Domain.Models;
using Task = System.Threading.Tasks.Task;

namespace ToDoList.Domain.Repositories
{
    public interface IGenericRepository<T> where T: BaseDomainEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<bool> Delete(int id);
    }
}