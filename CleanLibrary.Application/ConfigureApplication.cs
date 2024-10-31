using CleanLibrary.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace CleanLibrary.Application
{
    public static class ConfigureApplication
    {
        public static IServiceCollection AddApplication(
            this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
            services.AddAutoMapper(System.Reflection.Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
