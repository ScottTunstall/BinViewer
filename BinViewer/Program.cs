using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BinViewer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            var host = CreateHostBuilder().Build();
            
            Application.Run(host.Services.GetRequiredService<MainForm>());
        }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    //services.AddScoped<TInterface, TImplementation>();
                    services.Configure<AppSettings>(context.Configuration.GetSection("AppSettings"));
                    services.AddTransient<MainForm>();
                });
        }
    }
}