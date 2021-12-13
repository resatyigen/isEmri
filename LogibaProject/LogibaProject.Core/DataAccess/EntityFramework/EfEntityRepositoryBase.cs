using LogibaProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Core.DataAccess.EntityFramework
{
    public abstract class EfEntityRepositoryBase<TEntity, TContext>
       : IEntityRepository<TEntity>
       where TEntity : class, IEntity, new()
       where TContext : DbContext, new()
    {
        protected abstract List<TEntity> GetEntitiesAbstract(Expression<Func<TEntity,
            bool>> filter, TContext context);

        protected abstract TEntity GetEntityAbstract(TEntity entity, TContext context);

        protected abstract TEntity GetEntityAbstract(Expression<Func<TEntity, bool>> filter, TContext context);

        public TEntity Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);

                addedEntity.State = EntityState.Added;

                context.SaveChanges();

                return addedEntity.Entity;
            }
        }

        public TEntity Add(TEntity entity, string constr)
        {
            using (var context = new TContext())
            {
                context.Database.Connection.ConnectionString = constr;
                var addedEntity = context.Entry(entity);

                addedEntity.State = EntityState.Added;

                context.SaveChanges();

                return addedEntity.Entity;
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);

                updatedEntity.State = EntityState.Modified;

                context.SaveChanges();

                return updatedEntity.Entity;
            }
        }

        public TEntity Update(TEntity entity, string constr)
        {
            using (var context = new TContext())
            {
                context.Database.Connection.ConnectionString = constr;
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;

                context.SaveChanges();

                return updatedEntity.Entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;

                context.SaveChanges();
            }
        }

        public void Delete(Expression<Func<TEntity, bool>> filter = null)
        {
            var deletedEntity = Get(filter);
            Delete(deletedEntity);
        }
        public void Delete(TEntity entity, string constr)
        {
            using (var context = new TContext())
            {
                context.Database.Connection.ConnectionString = constr;
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public TEntity Get(TEntity entity)
        {
            using (var context = new TContext())
            {
                return GetEntityAbstract(entity, context);
            }
        }

        public TEntity Get(string constr, Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                context.Database.Connection.ConnectionString = constr;
                return GetEntityAbstract(filter, context);
            }
        }

        public TEntity Get(TEntity entity, string constr)
        {
            using (var context = new TContext())
            {
                context.Database.Connection.ConnectionString = constr;
                return GetEntityAbstract(entity, context);
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return GetEntityAbstract(filter, context);
            }
        }

        public List<TEntity> GetEntities(string constr, Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                context.Database.Connection.ConnectionString = constr;
                return GetEntitiesAbstract(filter, context);
            }
        }
        public List<TEntity> GetEntities(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return GetEntitiesAbstract(filter, context);
            }
        }
        public void Dispose()
        {

        }
    }
}
