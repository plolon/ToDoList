using MediatR;
using ToDoList.Application.Dtos.WorkItems;
using ToDoList.Domain.Models;

namespace ToDoList.Application.Features.WorkItems.Queries.Requests
{
    public class GetWorkItemByIdRequest :IRequest<WorkItemDto>
    {
        public int Id { get; set; }
    }
}
