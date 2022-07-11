using System.Collections.Generic;
using TravUpApi.Domain;

namespace TravUpApi.Services
{
    public interface ICustomerService
    {
        void Add(Customer model);
        void Add(IEnumerable<Customer> models);
        void Delete(int id);
        Customer Get(int id);
        IEnumerable<Customer> GetAll();
        void Update(Customer model);
        void Update(IEnumerable<Customer> models);
    }
}
