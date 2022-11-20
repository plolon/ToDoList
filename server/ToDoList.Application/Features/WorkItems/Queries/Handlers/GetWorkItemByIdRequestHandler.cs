using AutoMapper;
using MediatR;
using ToDoList.Application.Dtos.WorkItems;
using ToDoList.Application.Features.WorkItems.Queries.Requests;
using ToDoList.Domain.Models;
using ToDoList.Domain.Repositories;

namespace ToDoList.Application.Features.WorkItems.Queries.Handlers
{
    public class GetWorkItemByIdRequestHandler : IRequestHandler<GetWorkItemByIdRequest, WorkItemDto>
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
