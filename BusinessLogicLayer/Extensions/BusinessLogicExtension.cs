using BusinessLogicLayer.Filters.ModelValidationFilter;
using BusinessLogicLayer.Repositories.Abstract;
using BusinessLogicLayer.Repositories.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogicLayer.Extensions
{
    public static class BusinessLogicExtension
    {
        public static IServiceCollection BusinessLogicLayerExtension(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IRegisterRepository, RegisterRepository>();

            services.AddScoped<ValidateModelAttribute>();

            return services;
        }
    }
}
