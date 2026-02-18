using MedicoDent.Application.Abstractions;
using MedicoDent.Infrastructure.Persistence;
using MedicoDent.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MedicoDent.Infrastructure.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var raw = configuration.GetConnectionString("Default")!;
            var conn = Environment.ExpandEnvironmentVariables(raw);
            services.AddDbContext<AppDbContext>(o => o.UseSqlite(conn));

            // Repositories
            services.AddScoped<IPacijentRepository, PatientRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
