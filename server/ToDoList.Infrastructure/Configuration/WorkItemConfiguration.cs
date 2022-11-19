using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList.Domain.Models;

namespace ToDoList.Infrastructure.Configuration
{
    public class WorkItemConfiguration : IEntityTypeConfiguration<WorkItem>
    {
        public void Configure(EntityTypeBuilder<WorkItem> builder)
        {
            builder.HasData(
                new()
                {
                    Id=1,
                    Title = "WorkItem 1",
                    Description = "WorkItem 1 Description text"
                },
                new()
                {
                    Id =2,
                    Title = "WorkItem 2"
                },
                new()
                {
                    Id=3,
                    Title ="WorkItem 3",
                    Description = "WorkItem 3 Description longer text lorem ipsum"
                });
        }
    }
}
