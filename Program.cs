using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Empr.CoreServicesApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(ConfigLogging)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static void ConfigLogging(HostBuilderContext context, ILoggingBuilder builder)
        {
            //add custom logging
            //builder.AddFilter(DbLoggerCategory.Database.Connection.Name, LogLevel.Trace);
        }
    }
}
