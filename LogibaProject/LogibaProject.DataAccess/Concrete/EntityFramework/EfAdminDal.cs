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
    public class EfAdminDal:EfEntityRepositoryBase<Admin,LogibaProjectContext>,IAdminDal
    {
        protected override List<Admin> GetEntitiesAbstract(Expression<Func<Admin, bool>> filter, LogibaProjectContext context)
        {
            return filter == null
                ? context.Admins.ToList()
                : context.Admins.Where(filter).ToList();
        }

        protected override Admin GetEntityAbstract(Admin entity, LogibaProjectContext context)
        {
            throw new NotImplementedException();
        }

        protected override Admin GetEntityAbstract(Expression<Func<Admin, bool>> filter, LogibaProjectContext context)
        {
            return context.Admins.FirstOrDefault(filter);
        }
    }
}
