using MediatR;
using ToDoList.Application.Dtos.WorkItems;

namespace ToDoList.Application.Features.WorkItems.Commands.Requests
{
    public class CreateWorkItemRequest : IRequest<WorkItemDto>
    {
        public SaveWorkItemDto WorkItem { get; set; }
    }
}
