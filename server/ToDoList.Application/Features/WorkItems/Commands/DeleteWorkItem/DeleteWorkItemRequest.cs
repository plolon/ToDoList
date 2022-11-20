using MediatR;

namespace ToDoList.Application.Features.WorkItems.Commands.DeleteWorkItem
{
    public class DeleteWorkItemRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
