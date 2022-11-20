using AutoMapper;
using MediatR;
using ToDoList.Domain.Models;
using ToDoList.Domain.Repositories;

namespace ToDoList.Application.Features.WorkItems.Commands.DeleteWorkItem
{
    public class DeleteWorkItemRequestHandler : IRequestHandler<DeleteWorkItemRequest, bool>
    {
        private readonly IGenericRepository<WorkItem> _repository;
        private readonly IMapper _mapper;
        public DeleteWorkItemRequestHandler(IGenericRepository<WorkItem> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Handle(DeleteWorkItemRequest request, CancellationToken cancellationToken)
        {
            var result = await _repository.Delete(request.Id);
            if (result == true)
                _repository.SaveChangesAsync();
            return result;
        }
    }
}
