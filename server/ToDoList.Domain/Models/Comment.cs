using System.ComponentModel.DataAnnotations;
using ToDoList.Domain.Models.Common;

namespace ToDoList.Domain.Models
{
    public class Comment : BaseDomainEntity
    {
        [Required]
        public string Description { get; set; }
    }
}