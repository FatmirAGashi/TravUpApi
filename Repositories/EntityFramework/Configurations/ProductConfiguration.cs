using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravUpApi.Repositories.EntityFramework.Entities;

namespace TravUpApi.Repositories.EntityFramework.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.HasKey(p =>p.Id);
            builder.Property(p =>p.Id);
            builder.Property(p =>p.Price).IsRequired();
            builder.Property(p =>p.DateAdded);
            builder.Property(p => p.DateAdded);
        }
    }
}
