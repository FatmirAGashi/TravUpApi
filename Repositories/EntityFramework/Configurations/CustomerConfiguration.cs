using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravUpApi.Repositories.EntityFramework.Entities;

namespace TravUpApi.Repositories.EntityFramework.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<CustomerEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder.HasKey(p =>p.Id);
            builder.Property(p =>p.Id);
            builder.Property(p =>p.Name).IsRequired();
            builder.Property(p =>p.DateAdded);
            builder.Property(p => p.DateAdded);
        }
    }
}
