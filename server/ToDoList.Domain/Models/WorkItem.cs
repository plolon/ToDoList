using System.Collections.ObjectModel;
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
        
        public virtual IEnumerable<Comment> Comments { get; set; }

        public WorkItem()
        {
            Comments = new Collection<Comment>();
        }
    }
}