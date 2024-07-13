using StockEase.Arguments.Configuration;

namespace StockEase.API.Extensions
{
    public static class SettingsExtension
    {
        public static IServiceCollection ConfigureSettings(this IServiceCollection services, IConfiguration configuration)
        {
            configuration.GetSection("Jwt").Bind(new JwtSettings());
            return services;
        }
    }
}
