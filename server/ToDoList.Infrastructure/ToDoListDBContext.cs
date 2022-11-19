using Microsoft.EntityFrameworkCore;
using ToDoList.Domain.Models;

namespace ToDoList.Infrastructure
{
    public class ToDoListDBContext :DbContext
    {
        public ToDoListDBContext(DbContextOptions<ToDoListDBContext> options) : base(options)
        {
        }
        
        public DbSet<WorkItem> WorkItems { get; set; }
    }
}