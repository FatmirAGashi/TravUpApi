using Microsoft.EntityFrameworkCore;

namespace TravUpApi.Repositories.Abstractions
{
    public interface ITravelUpContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbSet<TEntity> Set<TEntity>(string name) where TEntity : class;
        int SaveChanges();
    }
}
