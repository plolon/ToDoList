using MediatR;
using ToDoList.Application.Features.WorkItems.Queries.Requests;
using ToDoList.Domain.Models;
using ToDoList.Domain.Repositories;

namespace ToDoList.Application.Features.WorkItems.Queries.Handlers
{
    public class GetWorkItemsListRequestHandler : IRequestHandler<GetWorkItemsListRequest, IEnumerable<WorkItem>>
    {
        private readonly IGenericRepository<WorkItem> _repository;

        public GetWorkItemsListRequestHandler(IGenericRepository<WorkItem> repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<WorkItem>> Handle(GetWorkItemsListRequest request, CancellationToken cancellationToken)
        {
            return await _repository.GetAll();
        }
    }
}
