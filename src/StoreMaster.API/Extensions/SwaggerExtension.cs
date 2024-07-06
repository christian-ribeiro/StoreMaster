using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;

namespace StoreMaster.API.Extensions
{
    public static class SwaggerExtension
    {
        public static IServiceCollection ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSingleton<IPostConfigureOptions<JwtBearerOptions>, ConfigureJwtBearerOptions>();

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

                c.OperationFilter<AuthorizeCheckOperationFilter>();
            });

            services.AddSwaggerGenNewtonsoftSupport();
            return services;
        }

        public static WebApplication ApplySwagger(this WebApplication app, IConfiguration configuration)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "StoreMaster API v1");
                c.DocumentTitle = "StoreMaster API Documentation";
                c.EnableFilter();
                c.DocExpansion(DocExpansion.None);
                c.DisplayRequestDuration();
                c.OAuthClientId(configuration["Authentication:Google:ClientId"]);
                c.OAuthClientSecret(configuration["Authentication:Google:ClientSecret"]);
                c.OAuthAppName("Store Master");
                c.OAuthUsePkce();
                c.OAuthScopeSeparator(" ");
                c.OAuthScopes("openid", "email", "profile");

            });
            return app;
        }

        public class ConfigureJwtBearerOptions : IPostConfigureOptions<JwtBearerOptions>
        {
            public void PostConfigure(string name, JwtBearerOptions options)
            {
                if (options.Events == null)
                    options.Events = new JwtBearerEvents();

                var originalOnTokenValidated = options.Events.OnTokenValidated;

                options.Events.OnTokenValidated = async context =>
                {
                    var idToken = context.SecurityToken as JwtSecurityToken;
                    if (idToken == null)
                    {
                        throw new SecurityTokenException("Invalid token format");
                    }

                    context.Principal.AddIdentity(new ClaimsIdentity(idToken.Claims));

                    if (originalOnTokenValidated != null)
                    {
                        await originalOnTokenValidated(context);
                    }
                };

                options.Events.OnAuthenticationFailed = async context =>
                {
                    var logger = context.HttpContext.RequestServices.GetRequiredService<ILogger<Program>>();
                    logger.LogError("Authentication failed.", context.Exception);
                };
            }
        }

        public class AuthorizeCheckOperationFilter : IOperationFilter
        {
            public void Apply(OpenApiOperation operation, OperationFilterContext context)
            {
                var authAttributes = context.MethodInfo.DeclaringType
                    .GetCustomAttributes(true)
                    .Union(context.MethodInfo.GetCustomAttributes(true))
                    .OfType<AuthorizeAttribute>();

                if (authAttributes.Any())
                {
                    operation.Responses.Add("401", new OpenApiResponse { Description = "Unauthorized" });
                    operation.Responses.Add("403", new OpenApiResponse { Description = "Forbidden" });

                    var oauth2Scheme = new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "oauth2" }
                    };

                    operation.Security = new List<OpenApiSecurityRequirement>
                    {
                        new OpenApiSecurityRequirement
                        {
                            [oauth2Scheme] = new[] { "openid", "email", "profile" }
                        }
                    };
                }
            }
        }
    }
}