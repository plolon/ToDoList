using System.ComponentModel.DataAnnotations;
using ToDoList.Domain.Models.Common;

namespace ToDoList.Domain.Models
{
    public class WorkItem : BaseDomainEntity
    {
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        public string? Description { get; set; }
    }
}