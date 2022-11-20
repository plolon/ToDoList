using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Application.Dtos.WorkItems;
using ToDoList.Application.Features.WorkItems.Queries.Requests;

namespace ToDoList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkItemsController :ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public WorkItemsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var workitems = await _mediator.Send(new GetWorkItemsListRequest());
            var results = _mapper.Map<IEnumerable<WorkItemDto>>(workitems);
            return Ok(results);
        }
    }
}
