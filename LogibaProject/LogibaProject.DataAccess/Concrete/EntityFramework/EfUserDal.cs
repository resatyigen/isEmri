using LogibaProject.Core.DataAccess.EntityFramework;
using LogibaProject.DataAccess.Abstract;
using LogibaProject.DataAccess.Concrete.EntityFramework.Context;
using LogibaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User, LogibaProjectContext>,IUserDal
    {
        protected override List<User> GetEntitiesAbstract(Expression<Func<User, bool>> filter, LogibaProjectContext context)
        {
            return filter == null
                ? context.Users.ToList()
                : context.Users.Where(filter).ToList();
        }

        protected override User GetEntityAbstract(User entity, LogibaProjectContext context)
        {
            throw new NotImplementedException();
        }

        protected override User GetEntityAbstract(Expression<Func<User, bool>> filter, LogibaProjectContext context)
        {
            return context.Users.FirstOrDefault(filter);
        }
    }
}
