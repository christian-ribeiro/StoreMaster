﻿namespace StockEase.API.Extensions
{
    public static class ControllerExtension
    {
        public static IServiceCollection ConfigureController(this IServiceCollection services)
        {
            services.AddControllers()
                    .AddJsonOptions(options =>
                    {
                        options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
                    });

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