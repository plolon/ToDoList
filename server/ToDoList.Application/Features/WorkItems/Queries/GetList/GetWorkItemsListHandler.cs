using AutoMapper;
using ToDoList.Application.Abstractions.Messaging;
using ToDoList.Application.Dtos.WorkItems;
using ToDoList.Domain.Models;
using ToDoList.Domain.Repositories;

namespace ToDoList.Application.Features.WorkItems.Queries.GetList
{
    public class GetWorkItemsListRequestHandler : IQueryHandler<GetWorkItemsListRequest, IEnumerable<WorkItemDto>>
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
