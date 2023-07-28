using DbStorageContext;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using StorageWebApi;

namespace StorageWebAp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                try
                {
                    var context = serviceProvider.GetRequiredService<DbInitializer>();
                    DbInitializer db = new DbInitializer();
                }
                catch(Exception exceprion){ }
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        }
    }
}