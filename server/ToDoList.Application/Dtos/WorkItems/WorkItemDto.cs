using ToDoList.Application.Dtos.Common;

namespace ToDoList.Application.Dtos.WorkItems
{
    public class WorkItemDto : BaseDto
    {
        public string Title { get; set; }
        public string? Description { get; set; }
    }
}
