using TravUpApi.Domain;
using TravUpApi.Repositories.Abstractions;
using TravUpApi.Repositories.EntityFramework.Entities;

namespace TravUpApi.Repositories
{
    public class ProductRepository : Repository<Product, ProductEntity>, IProductRepository
    {
        public ProductRepository(ITravelUpContext travelUpContext) : base(travelUpContext)
        {

        }
    }
}
