using System.Collections.Generic;
using TravUpApi.Domain;
using TravUpApi.Repositories.Abstractions;

namespace TravUpApi.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public void Add(Product model)
        {
            _repository.Add(model);
        }

        public void Add(IEnumerable<Product> models)
        {
            _repository.Add(models);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Product Get(int id)
        {
            var model = _repository.Get(id);

            return model;
        }

        public IEnumerable<Product> GetAll()
        {
            var models = _repository.GetAll();

            return models;
        }

        public void Update(Product model)
        {
            _repository.Update(model);
        }

        public void Update(IEnumerable<Product> models)
        {
            _repository.Update(models);
        }
    }
}
