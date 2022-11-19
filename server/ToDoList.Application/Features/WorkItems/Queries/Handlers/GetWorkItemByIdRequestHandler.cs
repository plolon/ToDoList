using MediatR;
using ToDoList.Application.Features.WorkItems.Queries.Requests;
using ToDoList.Domain.Models;
using ToDoList.Domain.Repositories;

namespace ToDoList.Application.Features.WorkItems.Queries.Handlers
{
    public class GetWorkItemByIdRequestHandler : IRequestHandler<GetWorkItemByIdRequest, WorkItem>
    {
        private readonly IGenericRepository<WorkItem> _repository;

        public GetWorkItemByIdRequestHandler(IGenericRepository<WorkItem> repository)
        {
            _repository = repository;
        }
        public async Task<WorkItem> Handle(GetWorkItemByIdRequest request, CancellationToken cancellationToken)
        {
            return await _repository.GetById(request.Id);
        }
    }
}
