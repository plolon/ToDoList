using AutoMapper;
using ToDoList.Application.Abstractions.Messaging;
using ToDoList.Application.Dtos.WorkItems;
using ToDoList.Domain.Models;
using ToDoList.Domain.Repositories;

namespace ToDoList.Application.Features.WorkItems.Commands.CreateWorkItem
{
    public class CreateWorkItemHandler : ICommandHandler<CreateWorkItemRequest, WorkItemDto>
    {
        private readonly IGenericRepository<WorkItem> _repository;
        private readonly IMapper _mapper;
        public CreateWorkItemHandler(IGenericRepository<WorkItem> repository, IMapper mapper)
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