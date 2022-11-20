using AutoMapper;
using MediatR;
using ToDoList.Application.Dtos.WorkItems;
using ToDoList.Application.Features.WorkItems.Commands.Requests;
using ToDoList.Domain.Models;
using ToDoList.Domain.Repositories;

namespace ToDoList.Application.Features.WorkItems.Commands.Handlers
{
    public class CreateWorkItemRequestHandler : IRequestHandler<CreateWorkItemRequest, WorkItemDto>
    {
        private readonly IGenericRepository<WorkItem> _repository;
        private readonly IMapper _mapper;
        public CreateWorkItemRequestHandler(IGenericRepository<WorkItem> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<WorkItemDto> Handle(CreateWorkItemRequest request, CancellationToken cancellationToken)
        {
            var domainWorkitem = _mapper.Map<WorkItem>(request.WorkItem);
            var workitem = await _repository.Create(domainWorkitem);
            await _repository.SaveChangesAsync();
            return _mapper.Map<WorkItemDto>(workitem);
        }
    }
}