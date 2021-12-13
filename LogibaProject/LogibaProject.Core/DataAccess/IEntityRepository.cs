using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Core.DataAccess
{
    public interface IEntityRepository<T>:IDisposable
    {
        T Add(T entity);
        T Add(T entity, string constr);

        T Update(T entity);

        T Update(T entity, string constr);

        void Delete(T entity);

        void Delete(Expression<Func<T, bool>> filter = null);
        void Delete(T entity, string constr);

        T Get(T entity);

        T Get(string constr, Expression<Func<T, bool>> filter = null);
        T Get(T entity, string constr);

        T Get(Expression<Func<T, bool>> filter = null);

        List<T> GetEntities(Expression<Func<T, bool>> filter = null);
        List<T> GetEntities(string constr, Expression<Func<T, bool>> filter = null);
    }
}
