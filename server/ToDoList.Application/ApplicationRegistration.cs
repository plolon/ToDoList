using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ToDoList.Application
{
    public static class ApplicationRegistration
    {
        public static IServiceCollection ConfigureApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
