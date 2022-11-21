using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Application.Features.Comments.Queries.GetByWorkItem;

namespace ToDoList.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentsController : ControllerBase
    {
        private readonly ISender _sender;

        public CommentsController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet("workitemid/{id}")]
        public async Task<IActionResult> GetByWorkItemId(int workItemId)
        {
            var comments = await _sender.Send(new GetCommentsByWorkItemIdRequest { WorkItemId = workItemId });
            return Ok(comments);
        }
    }
}