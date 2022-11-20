using ToDoList.Application.Abstractions.Messaging;
using ToDoList.Application.Dtos.WorkItems;

namespace ToDoList.Application.Features.WorkItems.Commands.UpdateWorkItem
{
    public class UpdateWorkItemRequest : ICommand<WorkItemDto>
    {
        public int Id { get; set; }
        public SaveWorkItemDto WorkItem { get; set; }
    }
}
