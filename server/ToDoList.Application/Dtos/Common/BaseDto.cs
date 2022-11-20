namespace ToDoList.Application.Dtos.Common
{
    public class BaseDto
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
