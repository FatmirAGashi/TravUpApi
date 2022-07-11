using Microsoft.Extensions.DependencyInjection;
using TravUpApi.Repositories;
using TravUpApi.Repositories.Abstractions;

namespace TravUpApi.Api.DependencyInjection
{
    public static class RepositoryExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
        }
    }
}
