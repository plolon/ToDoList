using MediatR;
using ToDoList.Application.Dtos.WorkItems;

namespace ToDoList.Application.Features.WorkItems.Commands.Requests
{
    public class UpdateWorkItemRequest : IRequest<WorkItemDto>
    {
        public int Id { get; set; }
        public SaveWorkItemDto WorkItem { get; set; }
    }
}
    