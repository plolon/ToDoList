using System.ComponentModel.DataAnnotations;

namespace ToDoList.Domain.Models
{
    public class Task : BaseDomainEntity
    {
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}