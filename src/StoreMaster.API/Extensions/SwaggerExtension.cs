using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;
using System.Reflection;

namespace StoreMaster.API.Extensions
{
    public static class SwaggerExtension
    {
        public static IServiceCollection ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "StoreMaster API", Version = "v1" });

                var securityScheme = new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.OAuth2,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Flows = new OpenApiOAuthFlows
                    {
                        AuthorizationCode = new OpenApiOAuthFlow
                        {
                            AuthorizationUrl = new Uri("https://accounts.google.com/o/oauth2/v2/auth"),
                            TokenUrl = new Uri("https://oauth2.googleapis.com/token"),
                            Scopes = new Dictionary<string, string>
                            {
                                { "openid", "OpenID Connect" },
                                { "email", "Access email" },
                                { "profile", "Access profile" }
                            }
                        }
                    }
                };

                c.AddSecurityDefinition("oauth2", securityScheme);

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        securityScheme,
                        new[] { "openid", "email", "profile" }
                    }
                });

                c.CustomOperationIds(apiDescription =>
                {
                    return apiDescription.TryGetMethodInfo(out MethodInfo methodInfo) ? methodInfo.Name : null;
                });

                c.TagActionsBy(api =>
                {
                    var actionDescriptor = api.ActionDescriptor as ControllerActionDescriptor;
                    return [actionDescriptor.ControllerName];
                });
            });

            services.AddSwaggerGenNewtonsoftSupport();
            return services;
        }

        public static WebApplication ApplySwagger(this WebApplication app, IConfiguration configuration)
        {
            var googleAuthNSection = configuration.GetSection("Authentication:Google");

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "StoreMaster API v1");
                c.DocumentTitle = "StoreMaster API Documentation";
                c.EnableFilter();
                c.DocExpansion(DocExpansion.None);
                c.DisplayRequestDuration();
                c.OAuthClientId(googleAuthNSection["ClientId"]);
                c.OAuthClientSecret(googleAuthNSection["ClientSecret"]);
                c.OAuthAppName("Store Master");
                c.OAuthUsePkce();
            });
            return app;
        }
    }
}