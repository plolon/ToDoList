using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Application.Dtos.WorkItems;
using ToDoList.Application.Features.WorkItems.Commands.CreateWorkItem;
using ToDoList.Application.Features.WorkItems.Commands.Requests;
using ToDoList.Application.Features.WorkItems.Queries.Requests;

namespace ToDoList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkItemsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WorkItemsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetWorkItemsListRequest());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _mediator.Send(new GetWorkItemByIdRequest { Id = id });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SaveWorkItemDto workitem)
        {
            var result = await _mediator.Send(new CreateWorkItemRequest { WorkItem = workitem });
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] SaveWorkItemDto workitem, int id)
        {
            var result = await _mediator.Send(new UpdateWorkItemRequest { WorkItem = workitem, Id = id });
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteWorkItemRequest { Id = id });
            return Ok(result);
        }
    }
}
