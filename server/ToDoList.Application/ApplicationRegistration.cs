using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using ToDoList.Application.Behaviors;
using ToDoList.Application.Profiles;

namespace ToDoList.Application
{
    public static class ApplicationRegistration
    {
        public static IServiceCollection ConfigureApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddValidatorsFromAssembly(typeof(ApplicationRegistration).Assembly);
            services.AddAutoMapper(typeof(MappingProfile));
            return services;
        }
    }
}
