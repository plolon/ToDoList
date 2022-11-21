using AutoMapper;
using ToDoList.Application.Abstractions.Messaging;
using ToDoList.Application.Dtos.WorkItems;
using ToDoList.Domain.Models;
using ToDoList.Domain.Repositories;

namespace ToDoList.Application.Features.WorkItems.Queries.GetById
{
    public class GetWorkItemByIdRequestHandler : IQueryHandler<GetWorkItemByIdRequest, WorkItemDto>
    {
        private readonly IGenericRepository<WorkItem> _repository;
        private readonly IMapper _mapper;

        public GetWorkItemByIdRequestHandler(IGenericRepository<WorkItem> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<WorkItemDto> Handle(GetWorkItemByIdRequest request, CancellationToken cancellationToken)
        {
            var workitem = await _repository.GetById(request.Id);
            return _mapper.Map<WorkItemDto>(workitem);
        }
    }
}
