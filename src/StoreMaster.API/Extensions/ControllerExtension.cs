namespace StoreMaster.API.Extensions
{
    public static class ControllerExtension
    {
        public static IServiceCollection ConfigureController(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            return services;
        }

        public static WebApplication ApplyController(this WebApplication app)
        {
            app.MapControllers();
            return app;
        }
    }
}