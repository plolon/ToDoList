using ToDoList.Application.Abstractions.Messaging;
using ToDoList.Application.Dtos.WorkItems;

namespace ToDoList.Application.Features.WorkItems.Queries.GetList
{
    public class GetWorkItemsListRequest : IQuery<IEnumerable<WorkItemDto>>
    {
    }
}
