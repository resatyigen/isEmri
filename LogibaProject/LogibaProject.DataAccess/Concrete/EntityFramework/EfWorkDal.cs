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
    public class EfWorkDal : EfEntityRepositoryBase<Work, LogibaProjectContext>, IWorkDal
    {
        protected override List<Work> GetEntitiesAbstract(Expression<Func<Work, bool>> filter, LogibaProjectContext context)
        {
            return filter == null
                ? context.Works.ToList()
                : context.Works.Where(filter).ToList();
        }

        protected override Work GetEntityAbstract(Work entity, LogibaProjectContext context)
        {
            return context.Works.FirstOrDefault(x => x == entity);
        }

        protected override Work GetEntityAbstract(Expression<Func<Work, bool>> filter, LogibaProjectContext context)
        {
            return context.Works.FirstOrDefault(filter);
        }
    }
}
