using ToDoList.Application.Abstractions.Messaging;
using ToDoList.Application.Dtos.Comments;

namespace ToDoList.Application.Features.Comments.Queries.GetByWorkItem
{
    public class GetCommentsByWorkItemIdRequest : IQuery<IEnumerable<CommentDto>>
    {
        public int WorkItemId { get; set; }
    }
}