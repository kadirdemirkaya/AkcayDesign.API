using DataAccessLayer.Context;
using DataAccessLayer.SeedDatas;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccessLayer.Extensions
{
    public static class DataAccessExtension
    {
        public static IServiceCollection DataAccessLayerExtension(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataDBContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<Seeder>();

            return services;
        }
    }
}