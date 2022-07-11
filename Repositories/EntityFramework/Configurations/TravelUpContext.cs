using Microsoft.EntityFrameworkCore;
using TravUpApi.Repositories.Abstractions;
using TravUpApi.Repositories.EntityFramework.Configurations;
using TravUpApi.Repositories.EntityFramework.Entities;

namespace TravUpApi.Repositories.EntityFramework
{
    public class TravelUpContext : DbContext, ITravelUpContext
    {
        public TravelUpContext(DbContextOptions<TravelUpContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomerConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
        }

        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<ProductEntity> Products { get; set; }

    }
}
