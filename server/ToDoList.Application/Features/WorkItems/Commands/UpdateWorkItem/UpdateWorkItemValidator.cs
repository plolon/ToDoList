using FluentValidation;

namespace ToDoList.Application.Features.WorkItems.Commands.UpdateWorkItem
{
    public class UpdateWorkItemValidator : AbstractValidator<UpdateWorkItemRequest>
    {
        public UpdateWorkItemValidator()
        {
            RuleFor(x => x.WorkItem.Title)
                .NotEmpty().WithMessage("{PropertyName} cannot be empty.")
                .MaximumLength(50).WithMessage("{PropertyName} cannot exceed 50 characters");

            RuleFor(x => x.WorkItem.Description)
                .MaximumLength(4096).WithMessage("{PropertyName} cannot exceed 4096 characters");

            RuleFor(x => x.Id)
                .NotNull().WithMessage("{PropertyName} cannot be empty.")
                .GreaterThan(0).WithMessage("{PropertyName} cannot be less than 0.");
        }
    }
}
