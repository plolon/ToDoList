using Microsoft.EntityFrameworkCore;
using ToDoList.Domain.Models;

namespace ToDoList.Infrastructure
{
    public class ToDoListDBContext : DbContext
    {
        public ToDoListDBContext(DbContextOptions<ToDoListDBContext> options) : base(options)
        {
        }

        public DbSet<WorkItem> WorkItems { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {
                if (entry.State.Equals(EntityState.Added))
                {
                    entry.Entity.CreatedOn = DateTime.Now;
                }
                entry.Entity.ModifiedOn = DateTime.Now;
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}