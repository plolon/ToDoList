using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Application.Features.WorkItems.Queries.Requests;

namespace ToDoList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkItemsController :ControllerBase
    {
        private readonly IMediator _mediator;

        public WorkItemsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var workitems = await _mediator.Send(new GetWorkItemsListRequest());
            return Ok(workitems);
        }
    }
}
