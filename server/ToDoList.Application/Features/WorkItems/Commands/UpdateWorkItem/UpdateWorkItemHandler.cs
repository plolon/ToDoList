using AutoMapper;
using ToDoList.Application.Abstractions.Messaging;
using ToDoList.Application.Dtos.WorkItems;
using ToDoList.Domain.Models;
using ToDoList.Domain.Repositories;

namespace ToDoList.Application.Features.WorkItems.Commands.UpdateWorkItem
{
    public class UpdateWorkItemHandler : ICommandHandler<UpdateWorkItemRequest, WorkItemDto>
    {
        private readonly IGenericRepository<WorkItem> _repository;
        private readonly IMapper _mapper;

        public UpdateWorkItemHandler(IGenericRepository<WorkItem> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<WorkItemDto> Handle(UpdateWorkItemRequest request, CancellationToken cancellationToken)
        {
            var dbEntity = await _repository.GetById(request.Id);
            var result = _mapper.Map(request.WorkItem, dbEntity);
            await _repository.SaveChangesAsync();
            return _mapper.Map<WorkItemDto>(result);
        }
    }
}
