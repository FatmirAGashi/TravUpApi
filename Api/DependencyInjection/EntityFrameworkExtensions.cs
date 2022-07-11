using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TravUpApi.Repositories.Abstractions;
using TravUpApi.Repositories.EntityFramework;

namespace TravUpApi.Api.DependencyInjection
{
    public static class EntityFrameworkExtensions
    {
        public static void AddEntityFrameworkSqlServer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TravelUpContext>(options =>
                                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<ITravelUpContext>(provider => provider.GetService<TravelUpContext>());

        } 
    }
}
