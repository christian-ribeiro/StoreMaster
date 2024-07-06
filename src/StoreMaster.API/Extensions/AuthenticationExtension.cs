using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using StoreMaster.Domain.Interface.Service;
using System.Security.Claims;

namespace StoreMaster.API.Extensions
{
    public static class AuthenticationExtension
    {
        public static IServiceCollection ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.Authority = configuration["Jwt:Authority"];
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = configuration["Jwt:Authority"],
                    ValidateAudience = true,
                    ValidAudience = configuration["Jwt:Audience"],
                    ValidateLifetime = true
                };

                options.Events = new JwtBearerEvents
                {
                    OnTokenValidated = async context =>
                    {
                        var userService = context.HttpContext.RequestServices.GetRequiredService<IUserService>();
                        var claims = context.Principal.Claims;
                        var email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                        var name = claims.FirstOrDefault(c => c.Type == "name")?.Value;
                        var providerUserId = claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

                        if (email != null && providerUserId != null)
                        {
                            long userId = userService.GetOrCreateOAuthUser("Google", providerUserId, email, name);

                            // Adicionar informações do usuário à ClaimsPrincipal
                            var identity = (ClaimsIdentity)context.Principal.Identity;
                            identity.AddClaim(new Claim("UserId", userId.ToString()));
                        }
                    }
                };

            })
            .AddCookie()
            .AddGoogle(options =>
            {
                var googleAuthNSection = configuration.GetSection("Authentication:Google");
                options.ClientId = googleAuthNSection["ClientId"];
                options.ClientSecret = googleAuthNSection["ClientSecret"];
            });
            ;

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AuthenticatedUsers", policy =>
                {
                    policy.RequireAuthenticatedUser();
                });
            });

            return services;
        }

        public static WebApplication ApplyAuthentication(this WebApplication app)
        {
            app.UseAuthentication();
            app.UseAuthorization();

            return app;
        }
    }
}