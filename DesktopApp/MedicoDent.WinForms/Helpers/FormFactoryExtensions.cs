using Microsoft.Extensions.DependencyInjection;

namespace MedicoDent.WinForms.DependencyInjection
{
    public static class FormFactoryExtensions
    {
        public static IServiceCollection AddFormFactory<TForm>(this IServiceCollection services)
            where TForm : class
        {
            services.AddTransient<TForm>();

            services.AddTransient<Func<TForm>>(provider =>
                () => provider.GetRequiredService<TForm>());

            return services;
        }

        public static IServiceCollection AddFormFactory<TParam, TForm>(this IServiceCollection services)
            where TForm : class
        {
            services.AddTransient<Func<TParam, TForm>>(provider =>
                param => ActivatorUtilities.CreateInstance<TForm>(provider, param));

            return services;
        }
    }
}