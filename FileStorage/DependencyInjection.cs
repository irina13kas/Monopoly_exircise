using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace DbStorageContext
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnnection"];
            services.AddDbContext<StorageDbContext>(options =>
            {
                options.UseSqlite(connectionString);
            });
            
            services.AddScoped<StorageDbContext>();

            return services;
        }
    }
}
