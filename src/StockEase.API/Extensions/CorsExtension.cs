namespace StockEase.API.Extensions
{
    public static class CorsExtension
    {
        public static IServiceCollection ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });

            return services;
        }

        public static WebApplication ApplyCors(this WebApplication app)
        {
            app.UseCors();
            return app;
        }
    }
}