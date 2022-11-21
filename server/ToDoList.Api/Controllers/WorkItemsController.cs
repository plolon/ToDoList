using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Application.Dtos.WorkItems;
using ToDoList.Application.Features.WorkItems.Commands.CreateWorkItem;
using ToDoList.Application.Features.WorkItems.Commands.DeleteWorkItem;
using ToDoList.Application.Features.WorkItems.Commands.UpdateWorkItem;
using ToDoList.Application.Features.WorkItems.Queries.GetById;
using ToDoList.Application.Features.WorkItems.Queries.GetList;

namespace ToDoList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkItemsController : ControllerBase
    {
        private readonly ISender _sender;

        public WorkItemsController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _sender.Send(new GetWorkItemsListRequest());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _sender.Send(new GetWorkItemByIdRequest { Id = id });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SaveWorkItemDto workitem)
        {
            var result = await _sender.Send(new CreateWorkItemRequest { WorkItem = workitem });
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] SaveWorkItemDto workitem, int id)
        {
            var result = await _sender.Send(new UpdateWorkItemRequest { WorkItem = workitem, Id = id });
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _sender.Send(new DeleteWorkItemRequest { Id = id });
            return Ok(result);
        }
    }
}
