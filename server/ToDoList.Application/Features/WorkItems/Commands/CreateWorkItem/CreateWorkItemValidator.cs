using FluentValidation;
using ToDoList.Application.Features.WorkItems.Commands.Requests;

namespace ToDoList.Application.Features.WorkItems.Commands.CreateWorkItem
{
    public class CreateWorkItemValidator : AbstractValidator<CreateWorkItemRequest>
    {
        public CreateWorkItemValidator()
        {
            RuleFor(x => x.WorkItem.Title)
                .NotEmpty()
                .WithMessage("{PropertyName} cannot be empty.")
                .MaximumLength(50)
                .WithMessage("{PropertyName} cannot exceed 50 charactersx");
            RuleFor(x => x.WorkItem.Description)
                .MaximumLength(4096)
                .WithMessage("{PropertyName} cannot exceed 4096 charactersx");
        }
    }
}
