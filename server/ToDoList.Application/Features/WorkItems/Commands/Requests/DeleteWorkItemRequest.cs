using MediatR;

namespace ToDoList.Application.Features.WorkItems.Commands.Requests
{
    public class DeleteWorkItemRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
