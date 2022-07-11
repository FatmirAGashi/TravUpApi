using Mapster;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TravUpApi.Domain;
using TravUpApi.Repositories.Abstractions;
using TravUpApi.Repositories.EntityFramework.Entities;

namespace TravUpApi.Repositories
{
    public class Repository<TDomain, TEntity> : IRepository<TDomain> where TDomain : BaseModel where TEntity : BaseEntity
    {
        protected ITravelUpContext Context;
        public Repository(ITravelUpContext travelUpContext)
        {
            Context = travelUpContext;
        }
        public void Add(TDomain model)
        {
             var entity = model.Adapt<TEntity>();
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
        }

        public void Add(IEnumerable<TDomain> models)
        {
            foreach (var model in models)
            {
                Add(model);
            }
        }

        public virtual void Delete(int id)
        {
            var entity = Context.Set<TEntity>().AsNoTracking().FirstOrDefault(x =>x.Id == id);

            if (entity == null)
            {
                return;
            }
            Context.Set<TEntity>().Remove(entity);
            Context.SaveChanges();
        }

        public virtual TDomain Get(int id)
        {
            var query = Context.Set<TEntity>() as IQueryable<TEntity>;
            var entity = query.FirstOrDefault(x =>x.Id == id);
            var model = entity.Adapt<TDomain>();

            return model;
        }

        public virtual IEnumerable<TDomain> GetAll()
        {
            var query = Context.Set<TEntity>() as IQueryable<TEntity>;
            var models = query.Adapt<IEnumerable<TDomain>>(); //Adapt<IEnumerable<Product>>()

            return models;
        }

        public virtual void Save()
        {
            Context.SaveChanges();
        }

        public virtual void Update(TDomain model)
        {
            var entityModel = model.Adapt<TEntity>();
            Context.SaveChanges();
        }

        public virtual void Update(IEnumerable<TDomain> models)
        {
            foreach (var model in models)
            {
                Update(model);
            };
        }
    }
}
