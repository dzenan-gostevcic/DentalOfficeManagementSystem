using MedicoDent.Application.DependencyInjection;
using MedicoDent.Infrastructure.DependencyInjection;
using MedicoDent.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MedicoDent.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dbFolder = Path.Combine(appData, "MedicoDent");
            Directory.CreateDirectory(dbFolder);

            using IHost host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(cfg =>
                {
                    cfg.AddJsonFile("appsettings.json", optional: false);
                })
                .ConfigureServices((ctx, services) =>
                {
                    services.AddServices();
                    services.AddRepositories(ctx.Configuration);
                    services.AddTransient<LoginPage>();
                })
                .Build();

            using (var scope = host.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                db.Database.Migrate();
            }

            using var runScope = host.Services.CreateScope();
            var form = runScope.ServiceProvider.GetRequiredService<LoginPage>();
            System.Windows.Forms.Application.Run(form);
        }
    }
}
