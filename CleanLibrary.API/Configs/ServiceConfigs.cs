using CleanLibrary.Application;
using CleanLibrary.Infrastructure;

namespace CleanLibrary.API.Configs
{
    public static class ServiceConfigs
    {
        public static IServiceCollection AddServiceConfigs(
            this IServiceCollection services,
            WebApplicationBuilder builder)
        {
            services.AddInfrastructure(builder.Configuration);
            services.AddApplication();
            return services;
        }
    }
}
