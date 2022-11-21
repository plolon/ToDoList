using ToDoList.Application.Abstractions.Messaging;
using ToDoList.Application.Dtos.WorkItems;

namespace ToDoList.Application.Features.WorkItems.Queries.GetById
{
    public class GetWorkItemByIdRequest :IQuery<WorkItemDto>
    {
        public int Id { get; set; }
    }
}
