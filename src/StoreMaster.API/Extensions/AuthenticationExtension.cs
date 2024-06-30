namespace StoreMaster.API.Extensions
{
    public static class AuthenticationExtension
    {
        public static IServiceCollection ConfigureAuthentication(this IServiceCollection services)
        {
            return services;
        }

        public static WebApplication ApplyAuthentication(this WebApplication app)
        {
            return app;
        }
    }
}