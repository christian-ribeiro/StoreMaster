using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Domain.Interface.Service;
using StoreMaster.Domain.Service;
using StoreMaster.Infrastructure.Persistence.Repository;

namespace StoreMaster.API.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services)
        {
            #region Repository
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddScoped<IStockConfigurationRepository, StockConfigurationRepository>();
            services.AddScoped<IStockMovementRepository, StockMovementRepository>();
            services.AddScoped<IStockMovementTypeRepository, StockMovementTypeRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            #endregion

            #region Service
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductCategoryService, ProductCategoryService>();
            services.AddScoped<IStockConfigurationService, StockConfigurationService>();
            services.AddScoped<IStockMovementService, StockMovementService>();
            services.AddScoped<IStockMovementTypeService, StockMovementTypeService>();
            services.AddScoped<IUserService, UserService>();
            #endregion
            return services;
        }
    }
}