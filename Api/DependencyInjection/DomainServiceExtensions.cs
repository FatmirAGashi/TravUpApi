using Microsoft.Extensions.DependencyInjection;
using TravUpApi.Repositories;
using TravUpApi.Repositories.Abstractions;
using TravUpApi.Repositories.EntityFramework;
using TravUpApi.Services;
using TravUpApi.Services.Concrete;

namespace TravUpApi.Api.DependencyInjection
{
    public static class DomainServiceExtensions
    {
        public static void AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICustomerService, CustomerService>();
        }
    }
}
