using AutoMapper;
using ToDoList.Application.Abstractions.Messaging;
using ToDoList.Application.Dtos.Comments;
using ToDoList.Domain.Repositories;

namespace ToDoList.Application.Features.Comments.Queries.GetByWorkItem
{
    public class GetCommentsByWorkItemIdHandler : IQueryHandler<GetCommentsByWorkItemIdRequest, IEnumerable<CommentDto>>
    {
        private readonly ICommentRepository _repository;
        private readonly IMapper _mapper;

        public GetCommentsByWorkItemIdHandler(ICommentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<IEnumerable<CommentDto>> Handle(GetCommentsByWorkItemIdRequest request, CancellationToken cancellationToken)
        {
            var comments = await _repository.GetCommentsByWorkItemId(request.WorkItemId);
            return _mapper.Map<IEnumerable<CommentDto>>(comments);
        }
    }
}