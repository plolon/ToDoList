using MediatR;
using ToDoList.Domain.Models;

namespace ToDoList.Application.Features.WorkItems.Queries.Requests
{
    public class GetWorkItemByIdRequest :IRequest<WorkItem>
    {
        public int Id { get; set; }
    }
}
