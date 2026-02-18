using MedicoDent.Application.Mapping;
using MedicoDent.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MedicoDent.Application.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // AutoMapper profiles
            services.AddAutoMapper(typeof(PacijentProfile));

            // Application services
            services.AddScoped<PatientService>();
            services.AddScoped<UserService>();

            return services;
        }
    }
}
