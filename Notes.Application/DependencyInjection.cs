using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;

namespace Notes.Application
{
    public static class DependencyInjection
        
    {
        public static IServiceCollection AddApplication(
            this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}
