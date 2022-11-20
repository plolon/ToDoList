using System.ComponentModel.DataAnnotations;

namespace ToDoList.Domain.Models.Common
{
    public class BaseDomainEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}