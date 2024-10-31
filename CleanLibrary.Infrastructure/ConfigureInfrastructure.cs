using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using CleanLibrary.Infrastructure.Data;
using CleanLibrary.Application.Interfaces;
using CleanLibrary.Infrastructure.Repositories;


namespace CleanLibrary.Infrastructure
{
    public static class ConfigureInfrastructure
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
             IConfiguration configuration)
        {
            services.AddDbContext<LibraryDataContext>(options =>
                {
                    options.UseInMemoryDatabase(databaseName: configuration.GetConnectionString("DefaultConnection") ?? "DEFAULT");
                    options.EnableSensitiveDataLogging();
                });

            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();


            return services;
            
        }

    }
}
