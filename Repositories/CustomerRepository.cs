using TravUpApi.Domain;
using TravUpApi.Repositories.Abstractions;
using TravUpApi.Repositories.EntityFramework.Entities;

namespace TravUpApi.Repositories
{
    public class CustomerRepository : Repository<Customer, CustomerEntity>, ICustomerRepository
    {
        public CustomerRepository(ITravelUpContext travelUpContext) : base(travelUpContext)
        {

        }
    }
}
