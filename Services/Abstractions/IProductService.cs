using System.Collections.Generic;
using TravUpApi.Domain;

namespace TravUpApi.Services
{
    public interface IProductService
    {
        void Add(Product model);
        void Add(IEnumerable<Product> models);
        void Delete(int id);
        Product Get(int id);
        IEnumerable<Product> GetAll();
        void Update(Product model);
        void Update(IEnumerable<Product> models);
    }
}
