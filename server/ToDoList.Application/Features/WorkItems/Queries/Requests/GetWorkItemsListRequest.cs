using MediatR;
using ToDoList.Domain.Models;

namespace ToDoList.Application.Features.WorkItems.Queries.Requests
{
    public class GetWorkItemsListRequest : IRequest<IEnumerable<WorkItem>>
    {
    }
}
