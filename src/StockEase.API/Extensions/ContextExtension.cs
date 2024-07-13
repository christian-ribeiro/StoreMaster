using Microsoft.EntityFrameworkCore;
using StockEase.Infrastructure.Persistence.Context;

namespace StockEase.API.Extensions
{
    public static class ContextExtension
    {
        public static IServiceCollection ConfigureContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionStrings:Default"];
            services.AddDbContext<AppDbContext>(cfg => cfg.UseMySQL(connectionString).EnableSensitiveDataLogging());

            return services;
        }
    }
}