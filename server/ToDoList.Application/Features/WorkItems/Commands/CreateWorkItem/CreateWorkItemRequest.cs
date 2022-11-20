using ToDoList.Application.Abstractions.Messaging;
using ToDoList.Application.Dtos.WorkItems;

namespace ToDoList.Application.Features.WorkItems.Commands.CreateWorkItem
{
    public class CreateWorkItemRequest : ICommand<WorkItemDto>
    {
        public SaveWorkItemDto WorkItem { get; set; }
    }
}
