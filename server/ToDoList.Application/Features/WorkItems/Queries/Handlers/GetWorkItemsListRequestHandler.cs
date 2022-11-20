using AutoMapper;
using MediatR;
using ToDoList.Application.Dtos.WorkItems;
using ToDoList.Application.Features.WorkItems.Queries.Requests;
using ToDoList.Domain.Models;
using ToDoList.Domain.Repositories;

namespace ToDoList.Application.Features.WorkItems.Queries.Handlers
{
    public class GetWorkItemsListRequestHandler : IRequestHandler<GetWorkItemsListRequest, IEnumerable<WorkItemDto>>
    {
        private readonly IGenericRepository<WorkItem> _repository;
        private readonly IMapper _mapper;

        public GetWorkItemsListRequestHandler(IGenericRepository<WorkItem> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<WorkItemDto>> Handle(GetWorkItemsListRequest request, CancellationToken cancellationToken)
        {
            var workitems = await _repository.GetAll();
            return _mapper.Map<IEnumerable<WorkItemDto>>(workitems);
        }
    }
}
