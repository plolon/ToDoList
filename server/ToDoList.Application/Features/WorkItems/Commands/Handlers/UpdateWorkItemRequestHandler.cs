using AutoMapper;
using MediatR;
using ToDoList.Application.Dtos.WorkItems;
using ToDoList.Application.Features.WorkItems.Commands.Requests;
using ToDoList.Domain.Models;
using ToDoList.Domain.Repositories;

namespace ToDoList.Application.Features.WorkItems.Commands.Handlers
{
    public class UpdateWorkItemRequestHandler : IRequestHandler<UpdateWorkItemRequest, WorkItemDto>
    {
        private readonly IGenericRepository<WorkItem> _repository;
        private readonly IMapper _mapper;

        public UpdateWorkItemRequestHandler(IGenericRepository<WorkItem> repository, IMapper mapper)
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
